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
    public class AllRoomBookingsPageModel : PageModel
    {
        public IRoomBookingService IRoomBookingService { get; set; }
        public List<RoomBooking> RoomBookings { get; set; }

        public AllRoomBookingsPageModel(IRoomBookingService iRoomBookingService)
        {
            IRoomBookingService = iRoomBookingService;
        }

        public void OnGet()
        {
            RoomBookings = IRoomBookingService.SortByAscending(IRoomBookingService.GetCurrentRoomBookings()).ToList();
        }

        public IActionResult OnGetAllBookings() 
        { 
            RoomBookings = IRoomBookingService.SortByAscending(IRoomBookingService.GetCurrentRoomBookings()).ToList();
            return Page();
        }

        public IActionResult OnGetMyBookings()
        {
            RoomBookings = IRoomBookingService.SortByAscending(IRoomBookingService.GetRoomBookingsByUserEmail(HttpContext.User.Identity.Name)).ToList();
            return Page();
        }

        public IActionResult OnGetOldBookings()
        {
            RoomBookings = IRoomBookingService.SortByAscending(IRoomBookingService.GetOldRoomBookings()).ToList();
            return Page();
        }

    }
}
