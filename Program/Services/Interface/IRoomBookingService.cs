using CTTSite.Models;

namespace CTTSite.Services.Interface
{
    // Made by Mille
    public interface IRoomBookingService
    {
        Task<bool> CreateRoomBookingAsync(RoomBooking roomBooking);
        Task<bool> UpdateRoomBookingAsync(RoomBooking roomBooking);
        Task DeleteRoomBookingByIDAsync(int iD);
        Task<List<RoomBooking>> GetAllRoomBookingsAsync();
        List<RoomBooking> GetCurrentRoomBookings();
        List<RoomBooking> GetOldRoomBookings();
        RoomBooking GetRoomBookingByID(int iD);
        List<RoomBooking> GetRoomBookingsByUserEmail(string userEmail);
        bool BookingIsAvailable(RoomBooking roomBooking);
        IEnumerable<RoomBooking> SortByAscending(List<RoomBooking> listRoomBookings);
        IEnumerable<RoomBooking> SortByDescending(List<RoomBooking> listRoomBookings);

    }
}
