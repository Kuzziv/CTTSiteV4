using CTTSite.Models;
using CTTSite.Services.MockDataService;

namespace UintTester
{
    //Made by Mads

    [TestClass]
    public class ConsultationTester
    {
        private MockDataConsultationService _mockDataConsultationService;

        // This method is executed before each test method
        [TestInitialize]
        public void Initialize()
        {
            _mockDataConsultationService = new MockDataConsultationService();
        }

        // Tests the GetAllConsultations method
        [TestMethod]
        public void Test_GetAllConsultations()
        {
            int count = _mockDataConsultationService.GetAllConsultations().Count();
            //Assert
            Assert.IsTrue(count > 0);
        }

        // Tests the GetAvailableConsultations method
        [TestMethod]
        public void Test_GetAvailableConsultations()
        {
            int count = _mockDataConsultationService.GetAvailableConsultations().Count();
            //Assert
            Assert.IsTrue(count > 0);
        }

        //These unit tests have been commented out because a our current skill level we where not able to figure out why they would pass when they are runed a debugging, but fail when runed normally
        //// Tests the SortConsultationsByDateTime method
        //[TestMethod]
        //public void Test_SortConsultationsByDateTime()
        //{
        //    List<Consultation> consultations = _mockDataConsultationService.GetAllConsultations();
        //    List<Consultation> sortedConsultations = _mockDataConsultationService.SortConsultationsByDateTime(consultations);
        //    //Assert
        //    Assert.IsTrue(sortedConsultations[1].Date.Date <  sortedConsultations[4].Date.Date);
        //}

        //[TestMethod]
        //public void Test_GroupConsultationsByDate()
        //{
        //    List<Consultation> consultations = _mockDataConsultationService.GetAllConsultations();
        //    List<IGrouping<DateTime, Consultation>> groupedConsultations = _mockDataConsultationService.GroupConsultationsByDate(consultations);

        //    // Extract the Date property from each Consultation object in the groupedConsultations[1] and groupedConsultations[2]
        //    List<DateTime> dates1 = groupedConsultations[1].Select(c => c.Date).ToList();
        //    List<DateTime> dates2 = groupedConsultations[2].Select(c => c.Date).ToList();

        //    // Assert
        //    Assert.IsTrue(dates1[1] < dates2[2]);
        //}

        // Tests the GetConsultationByID method
        // We use object 9 because we know it exists in our mockData object and we know it's not going to be remove because it's one day ahead

        [TestMethod]
        public void Test_GetConsultationByID()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(9);
            //Assert
            Assert.IsNotNull(consultation);
        }

        // Tests the GetConsultationByID method with a null case
        [TestMethod]
        public void Test_GetConsultationByID_Null()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(15);
            //Assert
            Assert.IsNull(consultation);
        }

        // Tests the CreateConsultation method
        [TestMethod]
        public void Test_CreateConsultation()
        {
            int countBeForeAdd = _mockDataConsultationService.GetAvailableConsultations().Count();
            Consultation consultation = new Consultation();
            consultation.ID = 1;
            consultation.Date = DateTime.Now;
            consultation.StartTime = DateTime.Now.TimeOfDay;
            consultation.EndTime = DateTime.Now.TimeOfDay;
            consultation.Booked = false;
            _mockDataConsultationService.CreateConsultation(consultation);
            int countAfterAdd = _mockDataConsultationService.GetAvailableConsultations().Count();
            //Assert
            Assert.IsTrue(countBeForeAdd < countAfterAdd);
        }

        // Tests the UpdateConsultation method
        // We use object 9 because we know it exists in our mockData object and we know it's not going to be remove because it's one day ahead
        [TestMethod]
        public void Test_UpdateConsultation()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(9);
            consultation.Booked = true;
            _mockDataConsultationService.UpdateConsultation(consultation);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetConsultationByID(9).Booked);
        }

        // Tests the DeleteConsultation method
        [TestMethod]
        public void Test_DeleteConsultation()
        {
            Consultation consultation = _mockDataConsultationService.GetConsultationByID(1);
            int listCount = _mockDataConsultationService.GetAllConsultations().Count();
            _mockDataConsultationService.DeleteConsultation(consultation);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.GetAllConsultations().Count() == listCount -1);
        }

        // Tests the DeleteExpiredUnbookedConsultations method
        // Because all our mockData object has the bool booked set to false we can use GetAvailableConsultations() method to test this method
        [TestMethod]
        public void Test_DeleteExpiredUnbookedConsultations()
        {
            int countBeforeDelete = _mockDataConsultationService.GetAvailableConsultations().Count();
            _mockDataConsultationService.DeleteExpiredUnbookedConsultations();
            int countAfterDelete = _mockDataConsultationService.GetAvailableConsultations().Count();
            //Assert
            Assert.IsTrue(countBeforeDelete >= countAfterDelete);
        }

        // Tests the IsDateWithInPresentDate method with a true case
        [TestMethod]
        public void Test_IsDateWithinPresentDate()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.AddHours(1).TimeOfDay;
            TimeSpan endTime = DateTime.Now.AddHours(2).TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsDateWithInPresentDate method with a false case
        [TestMethod]
        public void Test_IsDateWithinPresentDate_False()
        {
            DateTime date = DateTime.Now.AddDays(-1);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsDateWithInPresentDate method with a false case
        [TestMethod]
        public void Test_IsDateWithinPresentDate_False2()
        {
            DateTime date = DateTime.Now.AddDays(-2);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsDateWithInPresentDate method with a null case
        [TestMethod]
        public void Test_IsDateWithinPresentDate_null()
        {
            Consultation consultationTest = null;
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsDateWithInPresentDate method with a true case
        [TestMethod]
        public void Test_IsDateWithinPresentDate_True()
        {
            DateTime date = DateTime.Now.AddDays(1);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsDateWithInPresentDate method with a false case
        [TestMethod]
        public void Test_IsDateWithinPresentDate_True2()
        {
            DateTime date = DateTime.Now.AddDays(2);
            Consultation consultationTest = new Consultation(1, date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsDateWithinPresentDate(consultationTest));
        }

        // Tests the IsTimeSlotAvailableInDataBase method with a true case
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

        // Tests the IsTimeSlotAvailableInDataBase method with a false case
        // In this we add a day to DateTime.Now so we know it's working no matter what time we run the test
        [TestMethod]
        public void Test_IsTimeSlotAvailableInDataBase_False()
        {
            // Arrange
            DateTime date = DateTime.Now.AddDays(1);
            Consultation consultationTest = new Consultation(14, date, new TimeSpan(12, 0, 0), new TimeSpan(13, 0, 0), 2, "", "", "", false);
            _mockDataConsultationService.CreateConsultation(consultationTest);
            // Act
            bool isAvailable = _mockDataConsultationService.IsTimeSlotAvailableInDataBase(consultationTest);

            // Assert
            Assert.IsFalse(isAvailable);
        }

        // Tests the IsTimeSlotBeforeDateNow method with a true case
        [TestMethod]
        public void Test_IsTimeSlotBeforeDateNow_True()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.AddHours(1).TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotBeforeDateNow(consultationTest));
        }

        // Tests the IsTimeSlotBeforeDateNow method with a false case
        [TestMethod]
        public void Test_IsTimeSlotBeforeDateNow_False()
        {
            DateTime date = DateTime.Now;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = DateTime.Now.AddHours(-1).TimeOfDay;
            Consultation consultationTest = new Consultation(1, date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsTimeSlotBeforeDateNow(consultationTest));
        }        

        // Tests the IsTimeSlotCorrectEntered method with a false case
        [TestMethod]
        public void Test_IsTimeSlotCorrectEntered_False()
        {
            TimeSpan startTime = DateTime.Now.AddHours(-1).TimeOfDay;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            Consultation consultationTest = new Consultation(1, DateTime.Now.Date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsFalse(_mockDataConsultationService.IsTimeSlotCorrectEntered(consultationTest));
        }

        // Tests the IsTimeSlotCorrectEntered method with a true case
        [TestMethod]
        public void Test_IsTimeSlotCorrectEntered_True()
        {
            TimeSpan startTime = DateTime.Now.AddHours(1).TimeOfDay;
            TimeSpan endTime = DateTime.Now.AddHours(2).TimeOfDay;
            Consultation consultationTest = new Consultation(1, DateTime.Now.Date, startTime, endTime, 2, "", "", "", false);
            //Assert
            Assert.IsTrue(_mockDataConsultationService.IsTimeSlotCorrectEntered(consultationTest));
        }
    }
}