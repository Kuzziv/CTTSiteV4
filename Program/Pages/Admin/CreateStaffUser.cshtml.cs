using CTTSite.Services.Interface;
using CTTSite.Services.NormalService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;
using CTTSite.Models;
using Microsoft.AspNetCore.Identity;

namespace CTTSite.Pages.Staff.Admin
{
    // Made by Christian

    [Authorize(Roles = "admin")]
    public class CreateStaffUserModel : PageModel
    {
        private IUserService _iUserService;

        [BindProperty]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Message { get; set; }

        public Models.User newUser { get; set; }

        private PasswordHasher<string> _passwordHasher;

        public CreateStaffUserModel(IUserService userService)
        {
            _iUserService = userService;
            _passwordHasher = new PasswordHasher<string>();
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {           

            if (Email == null)
            {
                Message = "Please enter an email address";
                return Page();
            }

            if (!Email.Contains("@"))
            {
                Message = "Please use a valid email address!!!";
                return Page();
            }

			var chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz123456789!";
			var stringChars = new char[8];
			var random = new Random();

			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}

			Password = new String(stringChars);


            newUser = new Models.User(Email, _passwordHasher.HashPassword(null, Password), false, true); 
            if (_iUserService.AddUser(newUser).Result == true)
            {
                await _iUserService.AddUser(newUser);
                _iUserService.ForgottenPassword(newUser.Email, Password);

                return RedirectToPage("/Staff/UserCreatedConfirmation");
            }
            else
            {
                Message = "Email already exists!!!";
                return Page();
            }
        }
    }
}
