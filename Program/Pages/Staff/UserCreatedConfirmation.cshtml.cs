using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Staff
{
    // Made by Christian
    [Authorize(Roles = "staff")]
    public class UserCreatedConfirmationModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
