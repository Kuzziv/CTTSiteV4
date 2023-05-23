using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CTTSite.Pages.Admin
{
	// Made by Christian
	[Authorize(Roles = "admin")]
	public class UpdateUserModel : PageModel
    {
        private IUserService _userService;

        public UpdateUserModel(IUserService userService)
        {
            _userService = userService;
        }
        private PasswordHasher<string> passwordHasher;

        public string Message { get; set; }
        

        public Models.User user { get; set; }

        [BindProperty]
        public string Email { get; set; }
		
        [BindProperty, DataType(DataType.Password)]
		public string Password { get; set; }

        public IActionResult OnGet(int id)
        {
            user = _userService.GetUserByID(id);
            return Page();
        }

        public IActionResult OnPost(int id) 
        {
            user = _userService.GetUserByID(id);

            if (!ModelState.IsValid)
            {
                Message = "Something Went Wrong. Please Try Again";
                return RedirectToPage("UpdateUser", new {id = user.Id});
			}

            passwordHasher = new PasswordHasher<string>();
			user = _userService.GetUserByID(id);
			user.Id = user.Id;
            user.Email = Email;
			user.Password = passwordHasher.HashPassword(null, Password);
            user.Admin = user.Admin;
            user.Staff = user.Staff;

            
			_userService.UpdateUserAsync(user);
            return RedirectToPage("GetAllUsers");

        }
    }
}
