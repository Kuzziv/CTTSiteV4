using CTTSite.Models;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;
using CTTSite.MockData;
using Microsoft.AspNetCore.Http;
using CTTSite.Services.DB;
using System.Runtime.CompilerServices;

namespace CTTSite.Services.NormalService
{
    // Made by Christian

    /// <summary>
    /// This class is used to handle all user and login related functions.
    /// </summary>
    public class UserService : IUserService
    {
        #region Lists
        /// <summary>
        /// List of all users
        /// </summary>
        private List<User> _users { get; set; }

        /// <summary>
        /// List of all admins
        /// </summary>
        private List<User> _admins { get; set; }

        /// <summary>
        /// List of all staff
        /// </summary>
        private List<User> _staff { get; set; }

        /// <summary>
        /// List of all clients
        /// </summary>
        private List<User> _clients { get; set; }
        #endregion

        #region Services
        /// <summary>
        /// Dependency Injection for EmailService to allow for sending emails
        /// </summary>
        private IEmailService EmailService { get; set; }

        /// <summary>
        /// Dependency Injection for DBServiceGeneric to allow for database access
        /// </summary>
        private DBServiceGeneric<User> DBServiceGeneric { get; set; }

        #endregion
   

        public UserService(DBServiceGeneric<User> dBServiceGeneric, IEmailService emailService)
        {
            DBServiceGeneric = dBServiceGeneric;
            _users = GetUsersFromDB();
            _admins = GetAdmins();
            _staff = GetStaff();
            _clients = GetClients();
         
            EmailService = emailService;
        }

        

        #region Add User
        /// <summary>
        /// Adds a new user to the list of users as well as to the database. Checks before adding if the user already exists.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>True if user does not already exist. False if user already exists</returns>
        public async Task<bool> AddUser(User user)
        {
            User? existingUser =_users.Find(_user => _user.Email.ToLower() == user.Email.ToLower());

            if (existingUser == null)
            {
                _users.Add(user);				
                await DBServiceGeneric.AddObjectAsync(user);

				return true;
            }
            else
            {
                return false;
            }
        }
		#endregion			
        
        #region Get User ID by Email
        /// <summary>
        /// Gets the ID of a user by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>user.id as an int</returns>
        public int GetUserIdByEmail(string email)
        {
            User user = _users.Find(_user => _user.Email == email);
            return user.Id;
        }
        #endregion

        #region Get User by email
       /// <summary>
       /// Gets a user by email
       /// </summary>
       /// <param name="email"></param>
       /// <returns>User Object</returns>
        public User GetUserByEmail(string email)
        {
            User? user = _users.Find(_user => _user.Email == email);
            return user;
        }
        #endregion

        #region Private Get Users From DB
        /// <summary>
        /// Gets all users from the database
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersFromDB()
        {
            
            return DBServiceGeneric.GetObjectsAsync().Result.ToList();

        }
        #endregion

        #region Get Users 
        /// <summary>
        /// Gets All Users from the list of users
        /// </summary>
        /// <returns></returns>
        public  List<User> GetAllUsers()
        {          
           return _users;
        }
        #endregion

        #region Get User by ID
        /// <summary>
        /// Finds a user by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>User Object</returns>
        public User GetUserByID(int ID)
        {
            foreach (User user in _users)
            {
                if (user.Id == ID)
                {
                    return user;
                }
            }
            return null;
        }
        #endregion

        #region Get Staff
        /// <summary>
        /// Gets all staff members from the list of users
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetStaff()
        {
			List<User> users = new List<User>();
			foreach (User u in _users)
			{
				if (u.Staff == true)
				{
					users.Add(u);
				}
			}
			
			_staff = users;
            return _staff;
        }
        #endregion

        #region Get Clients
        /// <summary>
        /// Gets all clients from the list of users
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetClients()
        {
			List<User> users = new List<User>();
			foreach (User u in _users)
			{
				if ((u.Staff == false) && (u.Admin == false))
				{
					users.Add(u);
				}
			}
			
			_clients = users;
            return _clients;
        }
        #endregion

        #region Get Admins
        /// <summary>
        /// Gets all admins from the list of users
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetAdmins()
        {
			List<User> users = new List<User>();
			foreach (User u in _users)
			{
				if (u.Admin == true)
				{
					users.Add(u);
				}
			}
            _admins = users;
            return _admins;
        }
        #endregion       

        #region Search User by Email
        /// <summary>
        /// Searches for a user by email
        /// </summary>
        /// <param name="searchEmail"></param>
        /// <returns>List of users with emails like search string</returns>
        public List<User> SearchUserByEmail(string searchEmail)
        {
            var results = _users.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower()));
            return results.ToList();   
        }
        #endregion      

        #region Delete User by ID
        /// <summary>
        /// Deletes a user by ID from the list of users as well as from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Deleted User</returns>
        public async Task<User> DeleteUserByID(int ID)
        {
            User? userToBeDeleted = null;
            if (GetUserByID(ID) != null)
            {                
                userToBeDeleted = GetUserByID(ID);
				_users.Remove(userToBeDeleted);
                //DBServiceGeneric.SaveObjectsAsync(_users);
                await DBServiceGeneric.DeleteObjectAsync(userToBeDeleted);
            }
            return userToBeDeleted;
        }
        #endregion

        #region Update User
        /// <summary>
        /// Updates a user in the list of users as well as in the database
        /// </summary>
        /// <param name="userN"></param>
        /// <returns>Void</returns>
        public async Task UpdateUserAsync(User userN)
        {
            if (userN != null)
            {
                foreach (User userO in _users)
                {
                    if (userO.Id == userN.Id)
                    {
                        userO.Email = userN.Email;
                        userO.Password = userN.Password;
                        
                        await DBServiceGeneric.UpdateObjectAsync(userO);
                    }
                }
            }
        }
        #endregion

        #region Sort Users by ID
        /// <summary>
        /// Orgenises users by ID in ascending order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> SortById()
        {
            return from user in _users
                   orderby user.Id
                   select user;
        }
        #endregion

        #region Sort Users by ID Descending
        /// <summary>
        /// Orgenises users by ID in descending order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> SortByIdDescending()
        {
            return from user in _users
                   orderby user.Id descending
                   select user;
        }
        #endregion

        #region Sort Users by Email
        /// <summary>
        /// Orgenises users by Email in ascending order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> SortByEmail()
        {
            return from user in _users
                   orderby user.Email
                   select user;
        }
        #endregion

        #region Sort Users by Email Descending
        /// <summary>
        /// Orgenises users by Email in descending order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> SortByEmailDescending()
        {
            return from user in _users
                   orderby user.Email descending
                   select user;
        }
        #endregion

        #region Forgotten Password 
        /// <summary>
        /// Resets a users password and sends it to their email
        /// </summary>
        /// <param name="email"></param>
        public void ForgottenPassword(string email, string password)
        {
			User user = GetUserByEmail(email);
			if (user != null)
            {
				EmailService.SendEmail(new Email("Your Password is: " + password + "\nPlease log in with this new password and go to Edit User Details to choose a new password.", "Password Recovery", user.Email));
               
			}
		}
        #endregion


       
    }
}
