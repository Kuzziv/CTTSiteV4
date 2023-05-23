using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTTSite.Services.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CTTSite.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CTTSite.Pages.Admin
{
	// Made by Christian
	[Authorize(Roles = "admin")]
	public class DeleteUserModel : PageModel
    {  
        private IUserService _iUserService;

        [BindProperty]
        public Models.User? user { get; set; }

		public DeleteUserModel(IUserService iUserService)
		{
			_iUserService = iUserService;

		}

		public IActionResult OnGet(int id)
        {
			user = _iUserService.GetUserByID(id);
			if (user == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			Models.User? deletedUser = user;

			await _iUserService.DeleteUserByID(deletedUser.Id);
			
			if (deletedUser == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return RedirectToPage("GetAllUsers");
		}
	}
}
