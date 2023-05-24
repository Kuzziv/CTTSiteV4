using CTTSite.Migrations;
using CTTSite.Models;
using CTTSite.Models.Forms;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;
using System.Linq;
using Consultation = CTTSite.Models.Consultation;

namespace CTTSite.Services.NormalService
{
    public class ConsultationService : IConsultationService
    {
        private readonly IEmailService _emailService;
        private readonly DBServiceGeneric<Consultation> _dbServiceGeneric;
        private readonly JsonFileService<Consultation> _jsonFileService;
        private List<Consultation> _consultationsList;

        public ConsultationService(DBServiceGeneric<Consultation> dbServiceGeneric, JsonFileService<Consultation> jsonFileService, IEmailService emailService)
        {
            _dbServiceGeneric = dbServiceGeneric;
            _jsonFileService = jsonFileService;
            _emailService = emailService;
            _consultationsList = GetAllConsultationsAsync().Result;
        }

        public async Task<List<Consultation>> GetAllConsultationsAsync()
        {
            return (await _dbServiceGeneric.GetObjectsAsync()).ToList();
            //return JsonFileService.GetJsonObjects().ToList();
            //return MockData.MockDataConsultation.GetAllConsultations();
        }

        public async Task<List<Consultation>> GetAvailableConsultationsAsync()
        {
            await DeleteExpiredUnbookedConsultationsAsync();
            List<Consultation> allConsultations = await GetAllConsultationsAsync();
            DateTime currentDateTime = DateTime.Now.Date; // Get the current date without the time

            List<Consultation> availableConsultations = allConsultations
                .Where(c => !c.Booked && c.Date.Date >= currentDateTime)
                .ToList();

            return availableConsultations;
        }

        public List<Consultation> SortConsultationsByDateTime(List<Consultation> consultations)
        {
            return consultations.OrderBy(c => c.Date).ThenBy(c => c.StartTime).ToList();
        }

        public List<IGrouping<DateTime, Consultation>> GroupConsultationsByDate(List<Consultation> consultations)
        {
            return consultations.GroupBy(c => c.Date.Date).ToList();
        }

        public async Task<Consultation> GetConsultationByIDAsync(int ID)
        {
            //foreach (Consultation consultation in ConsultationsList)
            //{
            //    if (consultation.ID == ID)
            //    {
            //        return consultation;
            //    }
            //}
            return await _dbServiceGeneric.GetObjectByIdAsync(ID);
        }

        public async Task CreateConsultationAsync(Consultation consultation)
        {
            //int IDCount = 0;
            //foreach(Consultation listConsultation in ConsultationsList)
            //{
            //    if(IDCount < listConsultation.ID)
            //    {
            //        IDCount = listConsultation.ID;
            //    }
            //}
            //consultation.ID = IDCount + 1;
            consultation.Date = consultation.Date.Date;
            _consultationsList.Add(consultation);
            await _dbServiceGeneric.AddObjectAsync(consultation);
            //_jsonFileService.SaveJsonObjects(ConsultationsList);
        }

        public async Task DeleteConsultationAsync(Consultation consultation)
        {
            Consultation consultationToBeDeleted = null;
            if (consultation != null)
            {
                _consultationsList.Remove(consultation);
                //_ssonFileService.SaveJsonObjects(ConsultationsList);
                await _dbServiceGeneric.DeleteObjectAsync(consultation);
            }
        }

        public async Task UpdateConsultationAsync(Consultation consultationN)
        {
            await _dbServiceGeneric.UpdateObjectAsync(consultationN);
        }

        public async Task SubmitConsultationByEmailAsync(Consultation consultation, string email)
        {
            Consultation consultationToBeUpdated = await GetConsultationByIDAsync(consultation.ID);

            if (consultationToBeUpdated != null)
            {
                consultationToBeUpdated.BookedNamed = consultation.BookedNamed;
                consultationToBeUpdated.TelefonNumber = consultation.TelefonNumber;
                consultationToBeUpdated.BookedEmail = consultation.BookedEmail;
                consultationToBeUpdated.Booked = true;

                _emailService.SendEmail(new Email(consultation.ToString(), "Booking of Consultation: " + email, email));
                // Becuase Jennie is getting spamed
                //_emailService.SendEmail(new Email(consultation.ToString(), "Booking of Consultation: " + email, "chilterntalkingtherapies@gmail.com"));

                await _dbServiceGeneric.UpdateObjectAsync(consultationToBeUpdated);
            }
        }

        public async Task DeleteExpiredUnbookedConsultationsAsync()
        {
            List<Consultation> allConsultations = await GetAllConsultationsAsync();

            DateTime currentDateTime = DateTime.Now;

            List<Consultation> expiredUnbookedConsultations = allConsultations
                .Where(c => (!c.Booked && c.Date < currentDateTime.Date) 
                || (!c.Booked && c.Date == currentDateTime.Date && c.StartTime < currentDateTime.TimeOfDay)
                ).ToList();

            foreach (Consultation consultation in expiredUnbookedConsultations)
            {
                allConsultations.Remove(consultation);
                await _dbServiceGeneric.DeleteObjectAsync(consultation);
            }
        }

        //check for date is available
        public bool IsDateWithinPresentDate(Consultation consultation)
        {
            if (consultation == null)
            {
                return false;
            }
            if (consultation.Date.Date < DateTime.Now.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //check for time slot is available in database depeding on the date
        public async Task<bool> IsTimeSlotAvailableInDataBaseAsync(Consultation consultation)
        {
            TimeSpan duration = TimeSpan.FromMinutes(1); // Assuming you want to subtract 1 minutes
            List<Consultation> allConsultations = await GetAllConsultationsAsync();
            allConsultations = allConsultations.Where(c => c.Date == consultation.Date && (c.ID != consultation.ID)).ToList();
            foreach (Consultation consultationInList in allConsultations)
            {
                if ((consultationInList.StartTime == consultation.StartTime) || (consultationInList.EndTime.Subtract(duration) == consultation.StartTime))
                {
                    return false;
                }
            }
            return true;
        }

        // Check if the time slot is correct
        public bool IsTimeSlotCorrectEntered(Consultation consultation)
        {
            if ((consultation.StartTime > consultation.EndTime) || (consultation.StartTime == null) || (consultation.EndTime == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Check if the time slot is before the current date and time
        public bool IsTimeSlotBeforeDateNow(Consultation consultation)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime consultationDateTime = consultation.Date.Date + consultation.StartTime;

            if (consultationDateTime <= currentDateTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
