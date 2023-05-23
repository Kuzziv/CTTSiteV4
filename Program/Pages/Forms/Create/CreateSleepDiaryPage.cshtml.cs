using CTTSite.Models.Forms;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

// Made by Christian

namespace CTTSite.Pages.Forms
{
    public class CreateSleepDiaryPageModel : PageModel
    {
        private IFormService _formService;

        [BindProperty]
        public FormSleepDiary formSleepDiary { get; set; } = new FormSleepDiary();

        public CreateSleepDiaryPageModel(IFormService formService)
        {
            _formService = formService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostSaveForm()
        {
            _formService.CreateFormSleepDiary(formSleepDiary);
            return RedirectToPage("/Forms/FormsMenuPage");
        }

    }
}
