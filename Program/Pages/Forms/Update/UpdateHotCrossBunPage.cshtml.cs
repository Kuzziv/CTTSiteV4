using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Forms
{
    public class UpdateHotCrossBunPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormHotCrossBun formHotCrossBun { get; set; }
        public string message { get; set; }

        public UpdateHotCrossBunPageModel(IFormService formService)
        {
            _formService = formService;
        }



        public void OnGet()
        {
            if (_formService.GetFormHotCrossBunByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formHotCrossBun = _formService.GetFormHotCrossBunByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                RedirectToPage("/Forms/FormsMenuPage");
            }
        }

        public IActionResult OnPostSubmitForm()
        {
            bool filledOut = false;

           
            
            if ((formHotCrossBun.Emotions == "Please Fill Out") || (formHotCrossBun.Thoughts == "Please Fill Out") || (formHotCrossBun.Physical == "Please Fill Out") || (formHotCrossBun.Behaviours == "Please Fill Out"))
            {
                filledOut = false;
                message = "Please fill out the form before submission or save the form for later";
            }
            else
            {
                filledOut = true;
            }
           

            if (filledOut)
            {
                _formService.UpdateFormHotCrossBun(formHotCrossBun);
                

                _formService.SubmitFormHotCrossBun(formHotCrossBun, formHotCrossBun.UserEmail);
                _formService.DeleteFormHotCrossBun(formHotCrossBun);
                return RedirectToPage("/Forms/FormsMenuPage");
            }
            else
            {
                _formService.UpdateFormHotCrossBun(formHotCrossBun);
                formHotCrossBun = _formService.GetFormHotCrossBunById(formHotCrossBun.ID);

                return Page();
            }
        }

        public IActionResult OnPostSaveForm()
        {
            _formService.UpdateFormHotCrossBun(formHotCrossBun);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
