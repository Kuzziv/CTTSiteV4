using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Forms
{
    public class UpdateActivitySchedulePageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormActivitySchedule formActivitySchedule { get; set; }
        public string message { get; set; }

        public UpdateActivitySchedulePageModel(IFormService formService)
        {
            _formService = formService;
        }



        public void OnGet(int id)
        {
            if (_formService.GetFormActivityScheduleByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivitySchedule = _formService.GetFormActivityScheduleByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                RedirectToPage("/Forms/FormsMenuPage");
            }
        }

        public IActionResult OnPostSubmitForm()
        {
            bool filledOut = false;

            
                if ((formActivitySchedule.Score7 == "Please Fill Out") || (formActivitySchedule.Afternoon2 == "Please Fill Out"))
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
                _formService.UpdateFormActivitySchedule(formActivitySchedule);
                

                _formService.SubmitFormActivitySchedule(formActivitySchedule, formActivitySchedule.UserEmail);
                _formService.DeleteFormActivitySchedule(formActivitySchedule);
                return RedirectToPage("/Forms/FormsMenuPage");
            }
            else
            {
                _formService.UpdateFormActivitySchedule(formActivitySchedule);
                formActivitySchedule = _formService.GetFormActivityScheduleById(formActivitySchedule.ID);

                return Page();
            }
        }

        public IActionResult OnPostSaveForm()
        {
            _formService.UpdateFormActivitySchedule(formActivitySchedule);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
