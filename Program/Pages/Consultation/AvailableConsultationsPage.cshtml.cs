using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Consultation
{
    public class AvailableConsultationsPageModel : PageModel
    {
        private readonly IConsultationService _consultationService;

        public List<IGrouping<DateTime, Models.Consultation>> GroupedConsultations { get; set; }

        public AvailableConsultationsPageModel(IConsultationService consultationService)
        {
            _consultationService = consultationService;
        }

        public async Task OnGetAsync()
        {
            List<Models.Consultation> consultations = await _consultationService.GetAvailableConsultationsAsync();
            consultations = _consultationService.SortConsultationsByDateTime(consultations);
            GroupedConsultations = _consultationService.GroupConsultationsByDate(consultations);
        }
    }
}