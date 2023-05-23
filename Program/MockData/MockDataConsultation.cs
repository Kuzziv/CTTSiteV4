using CTTSite.Models;

namespace CTTSite.MockData
{
    public class MockDataConsultation
    {

        public static List<Consultation> consultationsList = new List<Consultation>()
        {
            new Consultation(1, DateTime.Now.Date, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 1, " ", " ", " ", false),
            new Consultation(2, DateTime.Now.Date, new TimeSpan(12, 0, 0), new TimeSpan(13, 0, 0), 1, " ", " ", " ", false),
            new Consultation(3, DateTime.Now.Date, new TimeSpan(14, 0, 0), new TimeSpan(15, 0, 0), 1, " ", " ", " ", false),
            new Consultation(4, DateTime.Now.Date, new TimeSpan(16, 0, 0), new TimeSpan(17, 0, 0), 1, " ", " ", " ", false),
            new Consultation(5, DateTime.Now.Date, new TimeSpan(18, 0, 0), new TimeSpan(19, 0, 0), 1, " ", " ", " ", false)
        };

        public static List<Consultation> GetAllConsultations()
        {
            return consultationsList;
        }

    }
}
