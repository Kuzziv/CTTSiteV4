using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Made by Christian

namespace CTTSite.Pages.Forms
{
    public class CreateHotCrossBunPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormHotCrossBun formHotCrossBun { get; set; } = new FormHotCrossBun();

        public CreateHotCrossBunPageModel(IFormService formService)
        {
            _formService = formService;
        }

        

        public void OnGet()
        {
            
        }

        public IActionResult OnPostSaveForm()
        {

            _formService.CreateFormHotCrossBun(formHotCrossBun);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
