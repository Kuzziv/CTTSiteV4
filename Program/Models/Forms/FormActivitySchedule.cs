using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models.Forms
{
    // Made by Christian
    public class FormActivitySchedule 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string UserEmail { get; set; }


        #region Day 1
        public string Day1 { get; set; }
        public string Morning1 { get; set; }
        public string Afternoon1 { get; set; }
        public string Evening1 { get; set; }
        public string Score1 { get; set; }
        #endregion
        #region Day 2
        public string Day2 { get; set; }
        public string Morning2 { get; set; }
        public string Afternoon2 { get; set; }
        public string Evening2 { get; set; }
        public string Score2 { get; set; }
        #endregion
        #region Day 3
        public string Day3 { get; set; }
        public string Morning3 { get; set; }
        public string Afternoon3 { get; set; }
        public string Evening3 { get; set; }
        public string Score3 { get; set; }
        #endregion
        #region Day 4
        public string Day4 { get; set; }
        public string Morning4 { get; set; }
        public string Afternoon4 { get; set; }
        public string Evening4 { get; set; }
        public string Score4 { get; set; }
        #endregion
        #region Day 5
        public string Day5 { get; set; }
        public string Morning5 { get; set; }
        public string Afternoon5 { get; set; }
        public string Evening5 { get; set; }
        public string Score5 { get; set; }
        #endregion
        #region Day 6
        public string Day6 { get; set; }
        public string Morning6 { get; set; }
        public string Afternoon6 { get; set; }
        public string Evening6 { get; set; }
        public string Score6 { get; set; }
        #endregion
        #region Day 7
        public string Day7 { get; set; }
        public string Morning7 { get; set; }
        public string Afternoon7 { get; set; }
        public string Evening7 { get; set; }
        public string Score7 { get; set; }
        #endregion

        public FormActivitySchedule()
        {
        }

        public FormActivitySchedule(string user, string day1, string morning1, string afternoon1, string evening1, string score1, string day2, string morning2, string afternoon2, string evening2, string score2, string day3, string morning3, string afternoon3, string evening3, string score3, string day4, string morning4, string afternoon4, string evening4, string score4, string day5, string morning5, string afternoon5, string evening5, string score5, string day6, string morning6, string afternoon6, string evening6, string score6, string day7, string morning7, string afternoon7, string evening7, string score7)
        {
            UserEmail = user;
            Day1 = day1;
            Morning1 = morning1;
            Afternoon1 = afternoon1;
            Evening1 = evening1;
            Score1 = score1;
            Day2 = day2;
            Morning2 = morning2;
            Afternoon2 = afternoon2;
            Evening2 = evening2;
            Score2 = score2;
            Day3 = day3;
            Morning3 = morning3;
            Afternoon3 = afternoon3;
            Evening3 = evening3;
            Score3 = score3;
            Day4 = day4;
            Morning4 = morning4;
            Afternoon4 = afternoon4;
            Evening4 = evening4;
            Score4 = score4;
            Day5 = day5;
            Morning5 = morning5;
            Afternoon5 = afternoon5;
            Evening5 = evening5;
            Score5 = score5;
            Day6 = day6;
            Morning6 = morning6;
            Afternoon6 = afternoon6;
            Evening6 = evening6;
            Score6 = score6;
            Day7 = day7;
            Morning7 = morning7;
            Afternoon7 = afternoon7;
            Evening7 = evening7;
            Score7 = score7;
        }

        public override string ToString()
        {
            return 
                $"Day 1: {Day1}\nMorning: {Morning1}\nAfternoon: {Afternoon1}\nEvening: {Evening1}\nScore: {Score1}\n\n" +
                $"Day 2: {Day2}\nMorning: {Morning2}\nAfternoon: {Afternoon2}\nEvening: {Evening2}\nScore: {Score2}\n\n" +
                $"Day 3: {Day3}\nMorning: {Morning3}\nAfternoon: {Afternoon3}\nEvening: {Evening3}\nScore: {Score3}\n\n" +
                $"Day 4: {Day4}\nMorning: {Morning4}\nAfternoon: {Afternoon4}\nEvening: {Evening4}\nScore: {Score4}\n\n" +
                $"Day 5: {Day5}\nMorning: {Morning5}\nAfternoon: {Afternoon5}\nEvening: {Evening5}\nScore: {Score5}\n\n" +
                $"Day 6: {Day6}\nMorning: {Morning6}\nAfternoon: {Afternoon6}\nEvening: {Evening6}\nScore: {Score6}\n\n" +
                $"Day 7: {Day7}\nMorning: {Morning7}\nAfternoon: {Afternoon7}\nEvening: {Evening7}\nScore: {Score7}\n\n";
        }
    }
}
