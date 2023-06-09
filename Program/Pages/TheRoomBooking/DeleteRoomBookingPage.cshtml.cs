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
    public class DeleteRoomBookingPageModel : PageModel
    {
        public IRoomBookingService IRoomBookingService { get; set; }

        [BindProperty]
        public RoomBooking RoomBooking { get; set; }

        public DeleteRoomBookingPageModel(IRoomBookingService iRoomBookingService)
        {
            IRoomBookingService = iRoomBookingService;
        }

        public void OnGet(int ID)
        {
            RoomBooking = IRoomBookingService.GetRoomBookingByID(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await IRoomBookingService.DeleteRoomBookingByIDAsync(RoomBooking.ID);
            return RedirectToPage("/TheRoomBooking/AllRoomBookingsPage");
        }
    }
}
