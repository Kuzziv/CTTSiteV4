using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Consultation
{
    [Authorize(Roles = "admin")]
    public class DeleteConsultationPageModel : PageModel
    {
        private readonly IConsultationService _consultationService;

        [BindProperty]
        public Models.Consultation Consultation { get; set; }

        public DeleteConsultationPageModel(IConsultationService consultationService)
        {
            _consultationService = consultationService;
        }

        public async Task OnGetAsync(int ID)
        {
            Consultation = await _consultationService.GetConsultationByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _consultationService.DeleteConsultationAsync(Consultation);
            return RedirectToPage("GetAllConsultaionsPage");
        }
    }
}
