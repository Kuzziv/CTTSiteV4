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
    public class SpecificRoomBookingPageModel : PageModel
    {
        public IRoomBookingService IRoomBookingService { get; set; }

        [BindProperty]
        public RoomBooking RoomBooking { get; set; }

        public SpecificRoomBookingPageModel(IRoomBookingService iRoomBookingService)
        {
            IRoomBookingService = iRoomBookingService;
        }

        public void OnGet(int ID)
        {
            RoomBooking = IRoomBookingService.GetRoomBookingByID(ID);
        }


    }
}
