using CTTSite.Models;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;

namespace CTTSite.Services.MockDataService
{
    public class MockDataConsultationService
    {
        public List<Consultation> ConsultationsList;

        public MockDataConsultationService()
        {
            ConsultationsList = GetAllConsultations();
        }


        public List<Consultation> GetAllConsultations()
        {
            return MockData.MockDataConsultation.GetAllConsultations();
        }

        public List<Consultation> GetAvailableConsultations()
        {
            List<Consultation> allConsultations = ConsultationsList;
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

        public Consultation GetConsultationByID(int ID)
        {
            foreach (Consultation consultationInList in ConsultationsList)
            {
                if (consultationInList.ID == ID)
                {
                    return consultationInList;
                }
            }
            return null;
        }

        public void CreateConsultation(Consultation consultation)
        {
            int IDCount = 0;
            foreach (Consultation listConsultation in ConsultationsList)
            {
                if (IDCount < listConsultation.ID)
                {
                    IDCount = listConsultation.ID;
                }
            }
            consultation.ID = IDCount + 1;
            consultation.Date = consultation.Date.Date;
            ConsultationsList.Add(consultation);
        }

        public void DeleteConsultation(Consultation consultation)
        {
            if (consultation != null)
            {
                ConsultationsList.Remove(consultation);
            }
        }

        public void UpdateConsultation(Consultation consultationN)
        {
            foreach(Consultation consultationInList in ConsultationsList)
            {
                if(consultationInList.ID == consultationN.ID)
                {
                    consultationInList.Date = consultationN.Date.Date;
                    consultationInList.StartTime = consultationN.StartTime;
                    consultationInList.EndTime = consultationN.EndTime;
                    consultationInList.UserID = consultationN.UserID;
                    consultationInList.BookedNamed = consultationN.BookedNamed;
                    consultationInList.TelefonNumber = consultationN.TelefonNumber;
                    consultationInList.BookedEmail = consultationN.BookedEmail;
                    consultationInList.Booked = consultationN.Booked;

                }
            }
        }

        public void DeleteExpiredUnbookedConsultations()
        {
            List<Consultation> allConsultations = ConsultationsList;

            DateTime currentDateTime = DateTime.Now;

            List<Consultation> expiredUnbookedConsultations = allConsultations
                .Where(c => (!c.Booked && c.Date < currentDateTime.Date) || (!c.Booked && c.Date == currentDateTime.Date && c.StartTime < currentDateTime.TimeOfDay))
                .ToList();

            foreach (Consultation consultation in expiredUnbookedConsultations)
            {
                allConsultations.Remove(consultation);
            }

            ConsultationsList = allConsultations;
        }

        public bool IsDateWithInPresentDate(Consultation consultation)
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

        public bool IsTimeSlotAvailableInDataBase(Consultation consultation)
        {
            TimeSpan duration = TimeSpan.FromMinutes(1); // Assuming you want to subtract 1 minutes
            List<Consultation> allConsultations = ConsultationsList;
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

        public bool IsTimeSlotBeforeDateNow(Consultation consultation)
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

        public bool IsTimeSlotCorrectEntered(Consultation consultation)
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
