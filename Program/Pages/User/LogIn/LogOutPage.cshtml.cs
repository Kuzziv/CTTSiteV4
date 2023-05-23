using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.User.LogIn
{
    public class LogOutPageModel : PageModel
    {
        // Made by Christian
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/index");
        }   
    }
}
