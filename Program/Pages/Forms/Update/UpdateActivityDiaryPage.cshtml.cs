using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTTSite.Models.Forms;
using Microsoft.Identity.Client;

// Made by Christian

namespace CTTSite.Pages.Forms
{
    public class UpdateActivityDiaryPageModel : PageModel
    {
        private IFormService _formService;
        public UpdateActivityDiaryPageModel(IFormService formService)
        {
            _formService = formService;
        }

        public string message { get; set; }

        [BindProperty]
        public FormActivityDiary formActivityDiary { get; set; } = new FormActivityDiary();

        public void OnGet(int id)
        {
            if (_formService.GetFormActivityDiaryByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivityDiary = _formService.GetFormActivityDiaryByUserEmail(HttpContext.User.Identity.Name);
            }
           else
            {
                RedirectToPage("/Forms/FormsMenuPage");
            }
        }

        public IActionResult OnPostSubmitForm() 
        { 
          bool filledOut = false;

            
            if ((formActivityDiary.Day7_2400 == "Please Fill Out") || (formActivityDiary.Day5_0700 == "Please Fill Out"))
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
               _formService.UpdateFormActivityDiary(formActivityDiary);
                

               _formService.SubmitFormActivityDiary(formActivityDiary, formActivityDiary.UserEmail);
               _formService.DeleteFormActivityDiary(formActivityDiary);
                return RedirectToPage("/Forms/FormsMenuPage");
            }
            else
            {
                _formService.UpdateFormActivityDiary(formActivityDiary);
                formActivityDiary = _formService.GetFormActivityDiaryById(formActivityDiary.ID);

                return Page();
            }
        }

        public IActionResult OnPostSaveForm() 
        {
            _formService.UpdateFormActivityDiary(formActivityDiary);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
