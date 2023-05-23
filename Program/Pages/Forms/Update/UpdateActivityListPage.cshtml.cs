using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Forms
{
    public class UpdateActivityListPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormActivityList formActivityList { get; set; }


        public string message { get; set; } 
        public UpdateActivityListPageModel(IFormService formService)
        {
            _formService = formService;
        }



        public void OnGet(int id)
        {
            if (_formService.GetFormActivityListByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivityList = _formService.GetFormActivityListByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                RedirectToPage("/Forms/FormsMenuPage");
            }
        }

        public IActionResult OnPostSubmitForm()
        {
            bool filledOut = false;


            if ((formActivityList.Exercise == "Please Fill Out Before Submission") || (formActivityList.Pleasure == "Please Fill Out Before Submission") || (formActivityList.Social == "Please Fill Out Before Submission") || (formActivityList.Achievement == "Please Fill Out Before Submission"))
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
                _formService.UpdateFormActivityList(formActivityList);
                

                _formService.SubmitFormActivityList(formActivityList, formActivityList.UserEmail);
                _formService.DeleteFormActivityList(formActivityList);
                return RedirectToPage("/Forms/FormsMenuPage");
            }
            else
            {
                _formService.UpdateFormActivityList(formActivityList);
                formActivityList = _formService.GetFormActivityListById(formActivityList.ID);

                return Page();
            }
        }

        public IActionResult OnPostSaveForm()
        {
            _formService.UpdateFormActivityList(formActivityList);
            return RedirectToPage("/Forms/FormsMenuPage");
        }
    }
}
