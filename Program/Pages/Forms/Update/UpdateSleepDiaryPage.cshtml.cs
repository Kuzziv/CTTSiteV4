using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Forms
{
    public class UpdateSleepDiaryPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormSleepDiary formSleepDiary { get; set; }
        public string message { get; set; }

        public UpdateSleepDiaryPageModel(IFormService formService)
        {
            _formService = formService;
        }

        public void OnGet(int id)
        {
            if (_formService.GetFormSleepDiaryByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formSleepDiary = _formService.GetFormSleepDiaryByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                RedirectToPage("/Forms/FormsMenuPage");
            }
        }

        public IActionResult OnPostSubmitForm()
        {
            bool filledOut = false;

            
            if ((formSleepDiary.Day2_TimeWokenUpInMorning == "Please Fill Out Before Submission") || (formSleepDiary.Day5_TotalTimeSleeping == "Please Fill Out Before Submission") || (formSleepDiary.Day7_HowRestedDoYouFeel == "Please Fill Out Before Submission"))
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
                _formService.UpdateFormSleepDiary(formSleepDiary);
               

                _formService.SubmitFormSleepDiary(formSleepDiary, formSleepDiary.UserEmail);
                _formService.DeleteFormSleepDiary(formSleepDiary);
                return RedirectToPage("/Forms/FormsMenuPage");
            }
            else
            {
                _formService.UpdateFormSleepDiary(formSleepDiary);
                formSleepDiary = _formService.GetFormSleepDiaryById(formSleepDiary.ID);

                return Page();
            }
        }

        public IActionResult OnPostSaveForm()
        {
            _formService.UpdateFormSleepDiary(formSleepDiary);
            return RedirectToPage("/Forms/FormsMenuPage");
        }


    }
}
