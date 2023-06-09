using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.TheRoomBooking
{
    // Made by Mille
    [Authorize(Roles = "staff")]
    public class UpdateRoomBookingPageModel : PageModel
    {
        public IRoomBookingService IRoomBookingService { get; set; }

        [BindProperty]
        public RoomBooking RoomBooking { get; set; }
        public string Message { get; set; }

        public UpdateRoomBookingPageModel(IRoomBookingService iRoomBookingService)
        {
            IRoomBookingService = iRoomBookingService;
        }

        public void OnGet(int ID)
        {
            RoomBooking = IRoomBookingService.GetRoomBookingByID(ID);
        }

        public IActionResult OnPost()
        {
            if (IRoomBookingService.UpdateRoomBookingAsync(RoomBooking).Result == true)
            {            
                return RedirectToPage("/TheRoomBooking/SpecificRoomBookingPage", new { id = RoomBooking.ID } );
            }
            else
            {
                Message = "Booking time slot is not available";
                return Page();
            }
        }

    }
}
