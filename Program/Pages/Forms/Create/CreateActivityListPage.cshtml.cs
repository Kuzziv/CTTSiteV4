using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTTSite.Models.Forms;

// Made by Christian

namespace CTTSite.Pages.Forms
{
    public class CreateActivityListPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty] 
        public FormActivityList formActivityList { get; set; } = new FormActivityList();

        public CreateActivityListPageModel(IFormService formService)
        {
            _formService = formService;
        }

        

        public void OnGet()
        {

        }

        public IActionResult OnPostSaveForm()
        {
            _formService.CreateFormActivityList(formActivityList);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
