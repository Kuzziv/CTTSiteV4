using CTTSite.Models;
using CTTSite.Models.Forms;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;

namespace CTTSite.Services.NormalService
{
    // Made by Mille
    public class RoomBookingService : IRoomBookingService
    {

        public DBServiceGeneric<RoomBooking> DBServiceGeneric;
        public IUserService IUserService;
        public List<RoomBooking> RoomBookings;

        public RoomBookingService(DBServiceGeneric<RoomBooking> dBServiceGeneric, IUserService iUserService)
        {
            DBServiceGeneric = dBServiceGeneric;
            IUserService = iUserService;
            RoomBookings = GetAllRoomBookingsAsync().Result;
        }

        #region Create Room Booking
        public async Task<bool> CreateRoomBookingAsync(RoomBooking roomBooking)
        {
            if (BookingIsAvailable(roomBooking))
            {
                RoomBookings.Add(roomBooking);
                await DBServiceGeneric.AddObjectAsync(roomBooking);
                return true;
            }
            return false;
        }
        #endregion

        #region Update Room Booking
        public async Task<bool> UpdateRoomBookingAsync(RoomBooking newRoomBooking)
        {
            RoomBookings = await GetAllRoomBookingsAsync();
            if (newRoomBooking != null)
            {
                foreach (RoomBooking OldRoomBooking in RoomBookings)
                {
                    if (OldRoomBooking.ID == newRoomBooking.ID)
                    {
                        if(BookingIsAvailable(newRoomBooking))
                        {
                            OldRoomBooking.StartDateTime = newRoomBooking.StartDateTime;
                            OldRoomBooking.EndDateTime = newRoomBooking.EndDateTime;
                            OldRoomBooking.Description = newRoomBooking.Description;
                            OldRoomBooking.UserEmail = newRoomBooking.UserEmail;

                            await DBServiceGeneric.UpdateObjectAsync(OldRoomBooking);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        #endregion

        #region Delete Room Booking
        public async Task DeleteRoomBookingByIDAsync(int iD)
        {
            RoomBookings = await GetAllRoomBookingsAsync();
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.ID == iD)
                {
                    RoomBookings.Remove(roomBooking);
                    await DBServiceGeneric.DeleteObjectAsync(roomBooking);
                    break;
                }
            }
        }
        #endregion

        #region Get All Room Bookings
        public async Task<List<RoomBooking>> GetAllRoomBookingsAsync()
        {
            foreach (RoomBooking roomBooking in DBServiceGeneric.GetObjectsAsync().Result.ToList())
            {
                if (roomBooking.EndDateTime.AddMonths(1) < DateTime.Now)
                {
                    await DBServiceGeneric.DeleteObjectAsync(roomBooking);
                }
            }
            return DBServiceGeneric.GetObjectsAsync().Result.ToList();
        }
        #endregion

        #region Get Current Room Bookings
        public List<RoomBooking> GetCurrentRoomBookings()
        {
            List<RoomBooking> CurrentRoomBookings = new List<RoomBooking>();
            foreach (RoomBooking roomBooking in GetAllRoomBookingsAsync().Result)
            {
                if (roomBooking.EndDateTime > DateTime.Now)
                {
                    CurrentRoomBookings.Add(roomBooking);
                }
            }
            return CurrentRoomBookings;
        }
        #endregion

        #region Get Old Room Bookings
        public List<RoomBooking> GetOldRoomBookings() 
        { 
            List<RoomBooking> OldRoomBookings = new List<RoomBooking>();
            foreach (RoomBooking roomBooking in GetAllRoomBookingsAsync().Result)
            {
                if (roomBooking.EndDateTime < DateTime.Now)
                {
                    OldRoomBookings.Add(roomBooking);
                }
            }
            return OldRoomBookings;
        }
        #endregion

        #region Get Room Booking By ID
        public RoomBooking GetRoomBookingByID(int iD)
        {
            RoomBookings = GetAllRoomBookingsAsync().Result;
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.ID == iD)
                {
                    return roomBooking;
                }
            }
            return null;
        }
        #endregion

        #region Get Room Booking By User Email
        public List<RoomBooking> GetRoomBookingsByUserEmail(string userEmail)
        {
            RoomBookings = GetCurrentRoomBookings();
            List<RoomBooking> UserRoomBookings = new List<RoomBooking>();
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.UserEmail == userEmail)
                {
                    UserRoomBookings.Add(roomBooking);
                }
            }
            return UserRoomBookings;
        }
        #endregion
    
        #region Check Room Booking Availability
        public bool BookingIsAvailable(RoomBooking roomBooking)
        {
            RoomBookings = GetCurrentRoomBookings();
            foreach (RoomBooking listRoomBooking in RoomBookings)
            {
                if(listRoomBooking.ID != roomBooking.ID)
                {
                    // If booking time slot overlaps with previous bookings
                    if (listRoomBooking.StartDateTime < roomBooking.EndDateTime && listRoomBooking.EndDateTime > roomBooking.StartDateTime)
                    {
                        return false;
                    }
                    continue;
                }
                // If booking StartDateTime is after booking EndDateTime
                if (roomBooking.StartDateTime > roomBooking.EndDateTime)
                {
                    return false;
                }
                // If booking time slot is in the past
                if (roomBooking.StartDateTime < DateTime.Now)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Sort By Ascending
        public IEnumerable<RoomBooking> SortByAscending(List<RoomBooking> listRoomBookings)
        {
            return from roomBooking in listRoomBookings
                   orderby roomBooking.StartDateTime
                   select roomBooking;
        }
        #endregion

        #region Sort By Descending
        public IEnumerable<RoomBooking> SortByDescending(List<RoomBooking> listRoomBookings)
        {
            return from roomBooking in listRoomBookings
                   orderby roomBooking.StartDateTime descending
                   select roomBooking;
        }
        #endregion

    }
}
