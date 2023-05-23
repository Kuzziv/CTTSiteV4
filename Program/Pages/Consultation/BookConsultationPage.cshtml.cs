using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Consultation
{
    public class BookConsultationPageModel : PageModel
    {
        private readonly IConsultationService _consultationService;

        [BindProperty]
        public Models.Consultation Consultation { get; set; }

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
            await _consultationService.SubmitConsultationByEmailAsync(Consultation, Consultation.BookedEmail);
            return RedirectToPage("AvailableConsultationsPage");
        }
    }
}
