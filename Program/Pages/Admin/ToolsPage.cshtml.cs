using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Admin
{   // Made by Christian
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "staff")]
    public class ToolsPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
