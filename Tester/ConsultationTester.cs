using CTTSite.Models;
using CTTSite.Services.MockDataService;

namespace UintTester
{
    [TestClass]
    public class ConsultationTester
    {
        private MockDataConsultationService _mockDataConsultationService;
        [TestInitialize]

        public void Initialize()
        {
            _mockDataConsultationService = new MockDataConsultationService();
        }

        [TestMethod]
        public void Test_GetAllConsultations()
        {
            int count = _mockDataConsultationService.GetAllConsultations().Count();
            //Assert
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void Test_GetAvailableConsultations()
        {
            int count = _mockDataConsultationService.GetAvailableConsultations().Count();
            //Assert
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void Test_SortConsultationsByDateTime()
        {
            List<Consultation> consultations = _mockDataConsultationService.GetAllConsultations();
            List<Consultation> sortedConsultations = _mockDataConsultationService.SortConsultationsByDateTime(consultations);
            //Assert
            Assert.IsTrue(sortedConsultations.Count() > 0);
        }

        [TestMethod]
        public void Test_GroupConsultationsByDate()
        {
            List<Consultation> consultations = _mockDataConsultationService.GetAllConsultations();
            List<IGrouping<DateTime, Consultation>> groupedConsultations = _mockDataConsultationService.GroupConsultationsByDate(consultations);
            //Assert
            Assert.IsTrue(groupedConsultations.Count() > 0);
        }

        [TestMethod]
        public void Test_GetConsultationByID()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(1);
            //Assert
            Assert.IsNotNull(consultation);
        }

        [TestMethod]
        public void Test_CreateConsultation()
        {
            Consultation consultation = new Consultation();
            consultation.ID = 1;
            consultation.Date = DateTime.Now;
            consultation.StartTime = DateTime.Now.TimeOfDay;
            consultation.EndTime = DateTime.Now.TimeOfDay;
            consultation.Booked = false;
            _mockDataConsultationService.CreateConsultation(consultation);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetAllConsultations().Count() > 0);
        }

        [TestMethod]
        public void Test_UpdateConsultation()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(1);
            consultation.Booked = true;
            _mockDataConsultationService.UpdateConsultation(consultation);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetConsultationByID(1).Booked);
        }

        [TestMethod]
        public void Test_DeleteConsultation()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(1);
            _mockDataConsultationService.DeleteConsultation(consultation);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetAllConsultations().Count() == 0);
        }

        [TestMethod]
        public void Test_DeleteExpiredUnbookedConsultations()
        {
            _mockDataConsultationService.DeleteExpiredUnbookedConsultations();
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetAllConsultations().Count() == 0);
        }

        [TestMethod]
        public void Test_IsDateWithInPresentDate()
        {
            DateTime date = DateTime.Now;
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsDateWithInPresentDate(consultationTest));
        }

        [TestMethod]
        public void Test_IsDateWithInPresentDate_False()
        {
            //

            DateTime date = DateTime.Now.AddDays(-1);

            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsDateWithInPresentDate(consultationTest));
        }

        [TestMethod]
        public void Test_IsDateWithInPresentDate_True()
        {
            DateTime date = DateTime.Now.AddDays(1);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsDateWithInPresentDate(consultationTest));
        }

        [TestMethod]
        public void Test_IsDateWithInPresentDate_False2()
        {
            DateTime date = DateTime.Now.AddDays(2);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsDateWithInPresentDate(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotAvailableInDataBase()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotAvailableInDataBase(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotAvailableInDataBase_False()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsTimeSlotAvailableInDataBase(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotAvailableInDataBase_True()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotAvailableInDataBase(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotBeforeDateNow_False()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsTimeSlotBeforeDateNow(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotBeforeDateNow_True()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotBeforeDateNow(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotCorrectEntered_False()
        {
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, DateTime.Now.Date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsTimeSlotCorrectEntered(consultationTest));
        }

        [TestMethod]
        public void Test_IsTimeSlotCorrectEntered_True()
        {
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, DateTime.Now.Date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotCorrectEntered(consultationTest));
        }
    }
}
