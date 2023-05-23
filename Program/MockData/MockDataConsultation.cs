using CTTSite.Models;

namespace CTTSite.MockData
{
    public class MockDataConsultation
    {

        public static List<Consultation> consultationsList = new List<Consultation>()
        {
            //new Consultation(1, "10-05-2023", new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), 1, " ", " ", " "),
            //new Consultation(2, "10-05-2023", new TimeSpan(11, 0, 0), new TimeSpan(12, 0, 0), 1, " ", " ", " "),
            //new Consultation(3, "10-05-2023", new TimeSpan(12, 0, 0), new TimeSpan(13, 0, 0), 1, " ", " ", " "),
            //new Consultation(4, "10-05-2023", new TimeSpan(13, 0, 0), new TimeSpan(14, 0, 0), 1, " ", " ", " "),
            //new Consultation(5, "10-05-2023", new TimeSpan(14, 0, 0), new TimeSpan(15, 0, 0), 1, " ", " ", " ")
        };

        public static List<Consultation> GetAllConsultations()
        {
            return consultationsList;
        }

    }
}
