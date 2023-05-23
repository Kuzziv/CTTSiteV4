using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Pages.User.LogIn
{
    // Made by Christian
	public class EditUserDetailsModel : PageModel
	{
		private IUserService _userService;

		public EditUserDetailsModel(IUserService userService)
		{
			_userService = userService;
		}
		private PasswordHasher<string>? passwordHasher;

		public string? Message { get; set; }



		public Models.User? user { get; set; }

		[BindProperty]
		public string? Email { get; set; }

		[BindProperty, DataType(DataType.Password)]
		public string? Password { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string? PasswordCheck { get; set; }

        public IActionResult OnGet()
		{
			user = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
			return Page();
		}

		public IActionResult OnPost(int id)
		{            
            if (Password == null)
            {
                return RedirectToPage("PasswordError");
            }

            bool containsUppercase = false;

            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    containsUppercase = true;
                    break;
                }
            }           

            if ((Password.Length < 6) && (!containsUppercase))
            {
                return RedirectToPage("PasswordError");
            }        

            if (!containsUppercase)
            {
                return RedirectToPage("PasswordError");
            }

            if (Password.Length < 6)
            {
                return RedirectToPage("PasswordError");
            }

            if(Password != PasswordCheck)
            {                
                return RedirectToPage("PasswordError");
            }   
           


			passwordHasher = new PasswordHasher<string>();
            user = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            user.Id = user.Id;
			user.Email = Email;
			user.Password = passwordHasher.HashPassword(null, Password);
			user.Admin = user.Admin;
			user.Staff = user.Staff;


			_userService.UpdateUserAsync(user);
			return RedirectToPage("/Index");
		}
	}
}
