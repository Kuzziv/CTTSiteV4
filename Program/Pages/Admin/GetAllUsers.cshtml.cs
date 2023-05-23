using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CTTSite.Pages.Staff.Admin
{
    // Made by Christian

    [Authorize(Roles = "admin")]
    public class GetAllUsersModel : PageModel
    {
        private IUserService _iUserService;
        public List<Models.User> _users {  get; set; }


        [BindProperty]
        public string? SearchString { get; set; }

        public GetAllUsersModel(IUserService userService)
        {
            _iUserService = userService;
            _users = _iUserService.GetAllUsers();
        }
        public void OnGet()
        {
           
        }

		public IActionResult OnGetAll()
		{
			_users = _iUserService.GetAllUsers();
			return Page();
		}

		public IActionResult OnGetSortById()
        {
            _users = _iUserService.SortById().ToList();
            return Page();
        }

        public IActionResult OnGetSortByIdDescending()
        {
            _users = _iUserService.SortByIdDescending().ToList();
            return Page();
        }

        public IActionResult OnGetSortByEmail()
        {
            _users = _iUserService.SortByEmail().ToList();
            return Page();
        }

        public IActionResult OnGetSortByNameEmail()
        {
            _users = _iUserService.SortByEmailDescending().ToList();
            return Page();
        }

        public IActionResult OnGetClients()
        {
            _users = _iUserService.GetClients().ToList();
            return Page();
        }

        public IActionResult OnGetStaff()
        {
            _users = _iUserService.GetStaff().ToList();
            return Page();
        }
       
        public IActionResult OnPostEmailSearch()
        {
            _users = _iUserService.SearchUserByEmail(SearchString).ToList();
            return Page();
        }

        
    }
}
