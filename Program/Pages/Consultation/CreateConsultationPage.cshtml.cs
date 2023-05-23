using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace CTTSite.Pages.Consultation
{
    [Authorize(Roles = "admin")]
    public class CreateConsultationModel : PageModel
    {
        private readonly IConsultationService _consultationService;
        private readonly IUserService _userService;

        public string Message { get; set; }
        public string MessageColor { get; set; }
        [BindProperty]
        public Models.Consultation Consultation { get; set; } = new Models.Consultation();

        public CreateConsultationModel(IConsultationService consultationService, IUserService userService)
        {
            _consultationService = consultationService;
            _userService = userService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Consultation.Date = Consultation.Date.Date;
            Consultation.StartTime = Consultation.StartTime;
            Consultation.EndTime = Consultation.EndTime;
            Consultation.UserID = _userService.GetUserIdByEmail(HttpContext.User.Identity.Name);
            Consultation.BookedNamed = "";
            Consultation.TelefonNumber = "";
            Consultation.BookedEmail = "";
            Consultation.Booked = false;
            if (_consultationService.IsDateWithInPresentDate(Consultation) == false)
            {
                Message = "You can't create a consultation in the past";
                MessageColor = "red";
                return Page();
            }
            else if (await _consultationService.IsTimeSlotAvailableInDataBaseAsync(Consultation) == false)
            {
                Message = "The Time slot that you have chosen is already taken";
                MessageColor = "red";
                return Page();
            }
            else if (_consultationService.IsTimeSlotCorrectEntered(Consultation) == false)
            {
                Message = "The Time slot entered is worng";
                MessageColor = "red";
                return Page();
            }
            else if (_consultationService.IsTimeSlotBeforeDateNow(Consultation) == false)
            {
                Message = "The Time slot entered is behind the present time";
                MessageColor = "red";
                return Page();
            }
            else
            {
                await _consultationService.CreateConsultationAsync(Consultation);
                return RedirectToPage("GetAllConsultaionsPage");
            }
        }
        
    }
}
