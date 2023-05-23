using CTTSite.Models;
using CTTSite.Services.DB;
using CTTSite.Services.JSON;

namespace CTTSite.Services.Interface
{
    // Made by Christian
    public interface IUserService
    {

        Task<bool> AddUser(User user);

        int GetUserIdByEmail(string email);

        List<User> GetAllUsers();

        User GetUserByID(int ID);

        User GetUserByEmail(string email);

        List<User> GetStaff();

        List<User> GetClients();

        List<User> GetAdmins();

        List<User> SearchUserByEmail(string searchEmail);

        Task<User> DeleteUserByID(int ID);

        Task UpdateUserAsync(User userN);

        IEnumerable<User> SortById();

        IEnumerable<User> SortByIdDescending();

        IEnumerable<User> SortByEmail();

        IEnumerable<User> SortByEmailDescending();


        void ForgottenPassword(string email);

        string SaveNewPassword(string password);





    }
}
