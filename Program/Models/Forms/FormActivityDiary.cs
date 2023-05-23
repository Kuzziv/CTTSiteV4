using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models.Forms
{
    // Made by Christian
    public class FormActivityDiary
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string UserEmail { get; set; }


        #region Day 1


        public string Day1 { get; set; }
        public string Day1_0600 { get; set; }
        public string Day1_0700 { get; set; }
        public string Day1_0800 { get; set; }
        public string Day1_0900 { get; set; }
        public string Day1_1000 { get; set; }
        public string Day1_1100 { get; set; }
        public string Day1_1200 { get; set; }
        public string Day1_1300 { get; set; }
        public string Day1_1400 { get; set; }
        public string Day1_1500 { get; set; }
        public string Day1_1600 { get; set; }
        public string Day1_1700 { get; set; }
        public string Day1_1800 { get; set; }
        public string Day1_1900 { get; set; }
        public string Day1_2000 { get; set; }
        public string Day1_2100 { get; set; }
        public string Day1_2200 { get; set; }
        public string Day1_2300 { get; set; }
        public string Day1_2400 { get; set; }
        #endregion
        #region Day 2
        public string Day2 { get; set; }
        public string Day2_0600 { get; set; }
        public string Day2_0700 { get; set; }
        public string Day2_0800 { get; set; }
        public string Day2_0900 { get; set; }
        public string Day2_1000 { get; set; }
        public string Day2_1100 { get; set; }
        public string Day2_1200 { get; set; }
        public string Day2_1300 { get; set; }
        public string Day2_1400 { get; set; }
        public string Day2_1500 { get; set; }
        public string Day2_1600 { get; set; }
        public string Day2_1700 { get; set; }
        public string Day2_1800 { get; set; }
        public string Day2_1900 { get; set; }
        public string Day2_2000 { get; set; }
        public string Day2_2100 { get; set; }
        public string Day2_2200 { get; set; }
        public string Day2_2300 { get; set; }
        public string Day2_2400 { get; set; }
        #endregion
        #region Day 3
        public string Day3 { get; set; }
        public string Day3_0600 { get; set; }
        public string Day3_0700 { get; set; }
        public string Day3_0800 { get; set; }
        public string Day3_0900 { get; set; }
        public string Day3_1000 { get; set; }
        public string Day3_1100 { get; set; }
        public string Day3_1200 { get; set; }
        public string Day3_1300 { get; set; }
        public string Day3_1400 { get; set; }
        public string Day3_1500 { get; set; }
        public string Day3_1600 { get; set; }
        public string Day3_1700 { get; set; }
        public string Day3_1800 { get; set; }
        public string Day3_1900 { get; set; }
        public string Day3_2000 { get; set; }
        public string Day3_2100 { get; set; }
        public string Day3_2200 { get; set; }
        public string Day3_2300 { get; set; }
        public string Day3_2400 { get; set; }
        #endregion
        #region Day 4
        public string Day4 { get; set; }
        public string Day4_0600 { get; set; }
        public string Day4_0700 { get; set; }
        public string Day4_0800 { get; set; }
        public string Day4_0900 { get; set; }
        public string Day4_1000 { get; set; }
        public string Day4_1100 { get; set; }
        public string Day4_1200 { get; set; }
        public string Day4_1300 { get; set; }
        public string Day4_1400 { get; set; }
        public string Day4_1500 { get; set; }
        public string Day4_1600 { get; set; }
        public string Day4_1700 { get; set; }
        public string Day4_1800 { get; set; }
        public string Day4_1900 { get; set; }
        public string Day4_2000 { get; set; }
        public string Day4_2100 { get; set; }
        public string Day4_2200 { get; set; }
        public string Day4_2300 { get; set; }
        public string Day4_2400 { get; set; }
        #endregion
        #region Day 5
        public string Day5 { get; set; }
        public string Day5_0600 { get; set; }
        public string Day5_0700 { get; set; }
        public string Day5_0800 { get; set; }
        public string Day5_0900 { get; set; }
        public string Day5_1000 { get; set; }
        public string Day5_1100 { get; set; }
        public string Day5_1200 { get; set; }
        public string Day5_1300 { get; set; }
        public string Day5_1400 { get; set; }
        public string Day5_1500 { get; set; }
        public string Day5_1600 { get; set; }
        public string Day5_1700 { get; set; }
        public string Day5_1800 { get; set; }
        public string Day5_1900 { get; set; }
        public string Day5_2000 { get; set; }
        public string Day5_2100 { get; set; }
        public string Day5_2200 { get; set; }
        public string Day5_2300 { get; set; }
        public string Day5_2400 { get; set; }
        #endregion
        #region Day 6
        public string Day6 { get; set; }
        public string Day6_0600 { get; set; }
        public string Day6_0700 { get; set; }
        public string Day6_0800 { get; set; }
        public string Day6_0900 { get; set; }
        public string Day6_1000 { get; set; }
        public string Day6_1100 { get; set; }
        public string Day6_1200 { get; set; }
        public string Day6_1300 { get; set; }
        public string Day6_1400 { get; set; }
        public string Day6_1500 { get; set; }
        public string Day6_1600 { get; set; }
        public string Day6_1700 { get; set; }
        public string Day6_1800 { get; set; }
        public string Day6_1900 { get; set; }
        public string Day6_2000 { get; set; }
        public string Day6_2100 { get; set; }
        public string Day6_2200 { get; set; }
        public string Day6_2300 { get; set; }
        public string Day6_2400 { get; set; }
        #endregion
        #region Day 7
        public string Day7 { get; set; }
        public string Day7_0600 { get; set; }
        public string Day7_0700 { get; set; }
        public string Day7_0800 { get; set; }
        public string Day7_0900 { get; set; }
        public string Day7_1000 { get; set; }
        public string Day7_1100 { get; set; }
        public string Day7_1200 { get; set; }
        public string Day7_1300 { get; set; }
        public string Day7_1400 { get; set; }
        public string Day7_1500 { get; set; }
        public string Day7_1600 { get; set; }
        public string Day7_1700 { get; set; }
        public string Day7_1800 { get; set; }
        public string Day7_1900 { get; set; }
        public string Day7_2000 { get; set; }
        public string Day7_2100 { get; set; }
        public string Day7_2200 { get; set; }
        public string Day7_2300 { get; set; }
        public string Day7_2400 { get; set; }
        #endregion


        public FormActivityDiary()
        {
        }

        #region Constructor
        public FormActivityDiary(string user,
            string day1, string day1_0600, string day1_0700, string day1_0800, string day1_0900, string day1_1000, string day1_1100, string day1_1200, string day1_1300, string day1_1400, string day1_1500, string day1_1600, string day1_1700, string day1_1800, string day1_1900, string day1_2000, string day1_2100, string day1_2200, string day1_2300, string day1_2400,
            string day2, string day2_0600, string day2_0700, string day2_0800, string day2_0900, string day2_1000, string day2_1100, string day2_1200, string day2_1300, string day2_1400, string day2_1500, string day2_1600, string day2_1700, string day2_1800, string day2_1900, string day2_2000, string day2_2100, string day2_2200, string day2_2300, string day2_2400,
            string day3, string day3_0600, string day3_0700, string day3_0800, string day3_0900, string day3_1000, string day3_1100, string day3_1200, string day3_1300, string day3_1400, string day3_1500, string day3_1600, string day3_1700, string day3_1800, string day3_1900, string day3_2000, string day3_2100, string day3_2200, string day3_2300, string day3_2400,
            string day4, string day4_0600, string day4_0700, string day4_0800, string day4_0900, string day4_1000, string day4_1100, string day4_1200, string day4_1300, string day4_1400, string day4_1500, string day4_1600, string day4_1700, string day4_1800, string day4_1900, string day4_2000, string day4_2100, string day4_2200, string day4_2300, string day4_2400,
            string day5, string day5_0600, string day5_0700, string day5_0800, string day5_0900, string day5_1000, string day5_1100, string day5_1200, string day5_1300, string day5_1400, string day5_1500, string day5_1600, string day5_1700, string day5_1800, string day5_1900, string day5_2000, string day5_2100, string day5_2200, string day5_2300, string day5_2400,
            string day6, string day6_0600, string day6_0700, string day6_0800, string day6_0900, string day6_1000, string day6_1100, string day6_1200, string day6_1300, string day6_1400, string day6_1500, string day6_1600, string day6_1700, string day6_1800, string day6_1900, string day6_2000, string day6_2100, string day6_2200, string day6_2300, string day6_2400,
            string day7, string day7_0600, string day7_0700, string day7_0800, string day7_0900, string day7_1000, string day7_1100, string day7_1200, string day7_1300, string day7_1400, string day7_1500, string day7_1600, string day7_1700, string day7_1800, string day7_1900, string day7_2000, string day7_2100, string day7_2200, string day7_2300, string day7_2400)
        {
            UserEmail = user;
            Day1 = day1;
            Day1_0600 = day1_0600;
            Day1_0700 = day1_0700;
            Day1_0800 = day1_0800;
            Day1_0900 = day1_0900;
            Day1_1000 = day1_1000;
            Day1_1100 = day1_1100;
            Day1_1200 = day1_1200;
            Day1_1300 = day1_1300;
            Day1_1400 = day1_1400;
            Day1_1500 = day1_1500;
            Day1_1600 = day1_1600;
            Day1_1700 = day1_1700;
            Day1_1800 = day1_1800;
            Day1_1900 = day1_1900;
            Day1_2000 = day1_2000;
            Day1_2100 = day1_2100;
            Day1_2200 = day1_2200;
            Day1_2300 = day1_2300;
            Day1_2400 = day1_2400;
            Day2 = day2;
            Day2_0600 = day2_0600;
            Day2_0700 = day2_0700;
            Day2_0800 = day2_0800;
            Day2_0900 = day2_0900;
            Day2_1000 = day2_1000;
            Day2_1100 = day2_1100;
            Day2_1200 = day2_1200;
            Day2_1300 = day2_1300;
            Day2_1400 = day2_1400;
            Day2_1500 = day2_1500;
            Day2_1600 = day2_1600;
            Day2_1700 = day2_1700;
            Day2_1800 = day2_1800;
            Day2_1900 = day2_1900;
            Day2_2000 = day2_2000;
            Day2_2100 = day2_2100;
            Day2_2200 = day2_2200;
            Day2_2300 = day2_2300;
            Day2_2400 = day2_2400;
            Day3 = day3;
            Day3_0600 = day3_0600;
            Day3_0700 = day3_0700;
            Day3_0800 = day3_0800;
            Day3_0900 = day3_0900;
            Day3_1000 = day3_1000;
            Day3_1100 = day3_1100;
            Day3_1200 = day3_1200;
            Day3_1300 = day3_1300;
            Day3_1400 = day3_1400;
            Day3_1500 = day3_1500;
            Day3_1600 = day3_1600;
            Day3_1700 = day3_1700;
            Day3_1800 = day3_1800;
            Day3_1900 = day3_1900;
            Day3_2000 = day3_2000;
            Day3_2100 = day3_2100;
            Day3_2200 = day3_2200;
            Day3_2300 = day3_2300;
            Day3_2400 = day3_2400;
            Day4 = day4;
            Day4_0600 = day4_0600;
            Day4_0700 = day4_0700;
            Day4_0800 = day4_0800;
            Day4_0900 = day4_0900;
            Day4_1000 = day4_1000;
            Day4_1100 = day4_1100;
            Day4_1200 = day4_1200;
            Day4_1300 = day4_1300;
            Day4_1400 = day4_1400;
            Day4_1500 = day4_1500;
            Day4_1600 = day4_1600;
            Day4_1700 = day4_1700;
            Day4_1800 = day4_1800;
            Day4_1900 = day4_1900;
            Day4_2000 = day4_2000;
            Day4_2100 = day4_2100;
            Day4_2200 = day4_2200;
            Day4_2300 = day4_2300;
            Day4_2400 = day4_2400;
            Day5 = day5;
            Day5_0600 = day5_0600;
            Day5_0700 = day5_0700;
            Day5_0800 = day5_0800;
            Day5_0900 = day5_0900;
            Day5_1000 = day5_1000;
            Day5_1100 = day5_1100;
            Day5_1200 = day5_1200;
            Day5_1300 = day5_1300;
            Day5_1400 = day5_1400;
            Day5_1500 = day5_1500;
            Day5_1600 = day5_1600;
            Day5_1700 = day5_1700;
            Day5_1800 = day5_1800;
            Day5_1900 = day5_1900;
            Day5_2000 = day5_2000;
            Day5_2100 = day5_2100;
            Day5_2200 = day5_2200;
            Day5_2300 = day5_2300;
            Day5_2400 = day5_2400;
            Day6 = day6;
            Day6_0600 = day6_0600;
            Day6_0700 = day6_0700;
            Day6_0800 = day6_0800;
            Day6_0900 = day6_0900;
            Day6_1000 = day6_1000;
            Day6_1100 = day6_1100;
            Day6_1200 = day6_1200;
            Day6_1300 = day6_1300;
            Day6_1400 = day6_1400;
            Day6_1500 = day6_1500;
            Day6_1600 = day6_1600;
            Day6_1700 = day6_1700;
            Day6_1800 = day6_1800;
            Day6_1900 = day6_1900;
            Day6_2000 = day6_2000;
            Day6_2100 = day6_2100;
            Day6_2200 = day6_2200;
            Day6_2300 = day6_2300;
            Day6_2400 = day6_2400;
            Day7 = day7;
            Day7_0600 = day7_0600;
            Day7_0700 = day7_0700;
            Day7_0800 = day7_0800;
            Day7_0900 = day7_0900;
            Day7_1000 = day7_1000;
            Day7_1100 = day7_1100;
            Day7_1200 = day7_1200;
            Day7_1300 = day7_1300;
            Day7_1400 = day7_1400;
            Day7_1500 = day7_1500;
            Day7_1600 = day7_1600;
            Day7_1700 = day7_1700;
            Day7_1800 = day7_1800;
            Day7_1900 = day7_1900;
            Day7_2000 = day7_2000;
            Day7_2100 = day7_2100;
            Day7_2200 = day7_2200;
            Day7_2300 = day7_2300;
            Day7_2400 = day7_2400;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return
                "Day 1: " + Day1 + "\n" +
                "Day 1 0600: " + Day1_0600 + "\n" +
                "Day 1 0700: " + Day1_0700 + "\n" +
                "Day 1 0800: " + Day1_0800 + "\n" +
                "Day 1 0900: " + Day1_0900 + "\n" +
                "Day 1 1000: " + Day1_1000 + "\n" +
                "Day 1 1100: " + Day1_1100 + "\n" +
                "Day 1 1200: " + Day1_1200 + "\n" +
                "Day 1 1300: " + Day1_1300 + "\n" +
                "Day 1 1400: " + Day1_1400 + "\n" +
                "Day 1 1500: " + Day1_1500 + "\n" +
                "Day 1 1600: " + Day1_1600 + "\n" +
                "Day 1 1700: " + Day1_1700 + "\n" +
                "Day 1 1800: " + Day1_1800 + "\n" +
                "Day 1 1900: " + Day1_1900 + "\n" +
                "Day 1 2000: " + Day1_2000 + "\n" +
                "Day 1 2100: " + Day1_2100 + "\n" +
                "Day 1 2200: " + Day1_2200 + "\n" +
                "Day 1 2300: " + Day1_2300 + "\n" +
                "Day 1 2400: " + Day1_2400 + "\n\n" +
                "Day 2: " + Day2 + "\n" +
                "Day 2 0600: " + Day2_0600 + "\n" +
                "Day 2 0700: " + Day2_0700 + "\n" +
                "Day 2 0800: " + Day2_0800 + "\n" +
                "Day 2 0900: " + Day2_0900 + "\n" +
                "Day 2 1000: " + Day2_1000 + "\n" +
                "Day 2 1100: " + Day2_1100 + "\n" +
                "Day 2 1200: " + Day2_1200 + "\n" +
                "Day 2 1300: " + Day2_1300 + "\n" +
                "Day 2 1400: " + Day2_1400 + "\n" +
                "Day 2 1500: " + Day2_1500 + "\n" +
                "Day 2 1600: " + Day2_1600 + "\n" +
                "Day 2 1700: " + Day2_1700 + "\n" +
                "Day 2 1800: " + Day2_1800 + "\n" +
                "Day 2 1900: " + Day2_1900 + "\n" +
                "Day 2 2000: " + Day2_2000 + "\n" +
                "Day 2 2100: " + Day2_2100 + "\n" +
                "Day 2 2200: " + Day2_2200 + "\n" +
                "Day 2 2300: " + Day2_2300 + "\n" +
                "Day 2 2400: " + Day2_2400 + "\n\n" +
                "Day 3: " + Day3 + "\n" +
                "Day 3 0600: " + Day3_0600 + "\n" +
                "Day 3 0700: " + Day3_0700 + "\n" +
                "Day 3 0800: " + Day3_0800 + "\n" +
                "Day 3 0900: " + Day3_0900 + "\n" +
                "Day 3 1000: " + Day3_1000 + "\n" +
                "Day 3 1100: " + Day3_1100 + "\n" +
                "Day 3 1200: " + Day3_1200 + "\n" +
                "Day 3 1300: " + Day3_1300 + "\n" +
                "Day 3 1400: " + Day3_1400 + "\n" +
                "Day 3 1500: " + Day3_1500 + "\n" +
                "Day 3 1600: " + Day3_1600 + "\n" +
                "Day 3 1700: " + Day3_1700 + "\n" +
                "Day 3 1800: " + Day3_1800 + "\n" +
                "Day 3 1900: " + Day3_1900 + "\n" +
                "Day 3 2000: " + Day3_2000 + "\n" +
                "Day 3 2100: " + Day3_2100 + "\n" +
                "Day 3 2200: " + Day3_2200 + "\n" +
                "Day 3 2300: " + Day3_2300 + "\n" +
                "Day 3 2400: " + Day3_2400 + "\n\n" +
                "Day 4: " + Day4 + "\n" +
                "Day 4 0600: " + Day4_0600 + "\n" +
                "Day 4 0700: " + Day4_0700 + "\n" +
                "Day 4 0800: " + Day4_0800 + "\n" +
                "Day 4 0900: " + Day4_0900 + "\n" +
                "Day 4 1000: " + Day4_1000 + "\n" +
                "Day 4 1100: " + Day4_1100 + "\n" +
                "Day 4 1200: " + Day4_1200 + "\n" +
                "Day 4 1300: " + Day4_1300 + "\n" +
                "Day 4 1400: " + Day4_1400 + "\n" +
                "Day 4 1500: " + Day4_1500 + "\n" +
                "Day 4 1600: " + Day4_1600 + "\n" +
                "Day 4 1700: " + Day4_1700 + "\n" +
                "Day 4 1800: " + Day4_1800 + "\n" +
                "Day 4 1900: " + Day4_1900 + "\n" +
                "Day 4 2000: " + Day4_2000 + "\n" +
                "Day 4 2100: " + Day4_2100 + "\n" +
                "Day 4 2200: " + Day4_2200 + "\n" +
                "Day 4 2300: " + Day4_2300 + "\n" +
                "Day 4 2400: " + Day4_2400 + "\n\n" +
                "Day 5: " + Day5 + "\n" +
                "Day 5 0600: " + Day5_0600 + "\n" +
                "Day 5 0700: " + Day5_0700 + "\n" +
                "Day 5 0800: " + Day5_0800 + "\n" +
                "Day 5 0900: " + Day5_0900 + "\n" +
                "Day 5 1000: " + Day5_1000 + "\n" +
                "Day 5 1100: " + Day5_1100 + "\n" +
                "Day 5 1200: " + Day5_1200 + "\n" +
                "Day 5 1300: " + Day5_1300 + "\n" +
                "Day 5 1400: " + Day5_1400 + "\n" +
                "Day 5 1500: " + Day5_1500 + "\n" +
                "Day 5 1600: " + Day5_1600 + "\n" +
                "Day 5 1700: " + Day5_1700 + "\n" +
                "Day 5 1800: " + Day5_1800 + "\n" +
                "Day 5 1900: " + Day5_1900 + "\n" +
                "Day 5 2000: " + Day5_2000 + "\n" +
                "Day 5 2100: " + Day5_2100 + "\n" +
                "Day 5 2200: " + Day5_2200 + "\n" +
                "Day 5 2300: " + Day5_2300 + "\n" +
                "Day 5 2400: " + Day5_2400 + "\n\n" +
                "Day 6: " + Day6 + "\n" +
                "Day 6 0600: " + Day6_0600 + "\n" +
                "Day 6 0700: " + Day6_0700 + "\n" +
                "Day 6 0800: " + Day6_0800 + "\n" +
                "Day 6 0900: " + Day6_0900 + "\n" +
                "Day 6 1000: " + Day6_1000 + "\n" +
                "Day 6 1100: " + Day6_1100 + "\n" +
                "Day 6 1200: " + Day6_1200 + "\n" +
                "Day 6 1300: " + Day6_1300 + "\n" +
                "Day 6 1400: " + Day6_1400 + "\n" +
                "Day 6 1500: " + Day6_1500 + "\n" +
                "Day 6 1600: " + Day6_1600 + "\n" +
                "Day 6 1700: " + Day6_1700 + "\n" +
                "Day 6 1800: " + Day6_1800 + "\n" +
                "Day 6 1900: " + Day6_1900 + "\n" +
                "Day 6 2000: " + Day6_2000 + "\n" +
                "Day 6 2100: " + Day6_2100 + "\n" +
                "Day 6 2200: " + Day6_2200 + "\n" +
                "Day 6 2300: " + Day6_2300 + "\n" +
                "Day 6 2400: " + Day6_2400 + "\n\n" +
                "Day 7: " + Day7 + "\n" +
                "Day 7 0600: " + Day7_0600 + "\n" +
                "Day 7 0700: " + Day7_0700 + "\n" +
                "Day 7 0800: " + Day7_0800 + "\n" +
                "Day 7 0900: " + Day7_0900 + "\n" +
                "Day 7 1000: " + Day7_1000 + "\n" +
                "Day 7 1100: " + Day7_1100 + "\n" +
                "Day 7 1200: " + Day7_1200 + "\n" +
                "Day 7 1300: " + Day7_1300 + "\n" +
                "Day 7 1400: " + Day7_1400 + "\n" +
                "Day 7 1500: " + Day7_1500 + "\n" +
                "Day 7 1600: " + Day7_1600 + "\n" +
                "Day 7 1700: " + Day7_1700 + "\n" +
                "Day 7 1800: " + Day7_1800 + "\n" +
                "Day 7 1900: " + Day7_1900 + "\n" +
                "Day 7 2000: " + Day7_2000 + "\n" +
                "Day 7 2100: " + Day7_2100 + "\n" +
                "Day 7 2200: " + Day7_2200 + "\n" +
                "Day 7 2300: " + Day7_2300 + "\n" +
                "Day 7 2400: " + Day7_2400 + "\n";

        }
        #endregion
    }
}

