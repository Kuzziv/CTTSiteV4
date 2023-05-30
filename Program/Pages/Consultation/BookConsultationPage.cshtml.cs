using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Consultation
{
    //Made by Mads
    public class BookConsultationPageModel : PageModel
    {
        private readonly IConsultationService _consultationService;

        [BindProperty]
        public Models.Consultation Consultation { get; set; }

        public string message { get; set; }

        public BookConsultationPageModel(IConsultationService consultationService)
        {
            _consultationService = consultationService;
        }

        public async Task OnGetAsync(int ID)
        {
            Consultation = await _consultationService.GetConsultationByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(!Consultation.BookedEmail.Contains("@") && !Consultation.BookedEmail.Contains("."))
            {
                message = "Please enter a valid email address";
                return Page();
            }
            if (Consultation.BookedEmail.Contains("@") && Consultation.BookedEmail.Contains("."))
            {
                await _consultationService.SubmitConsultationByEmailAsync(Consultation, Consultation.BookedEmail);
                return RedirectToPage("AvailableConsultationsPage");
            }
            await _consultationService.SubmitConsultationByEmailAsync(Consultation, Consultation.BookedEmail);
            return RedirectToPage("AvailableConsultationsPage");
        }
    }
}
