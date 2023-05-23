using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models.Forms
{
    // Made by Christian
    public class FormSleepDiary 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string UserEmail { get; set; }

        #region Day 1
        public string Day1 { get; set; } 
        public string Day1_TimeInBed { get; set; } 
        public string Day1_HowLongToSleep { get; set; }
        public string Day1_AmountOfTimesWokenUp { get; set; } 
        public string Day1_TotalTimeAwakeInNight { get; set; } 
        public string Day1_TimeWokenUpInMorning { get; set; } 
        public string Day1_TimeGottenOutOfBed { get; set; } 
        public string Day1_TotalTimeSpentInBed { get; set; } 
        public string Day1_TotalTimeSleeping { get; set; } 
        public string Day1_HowRestedDoYouFeel { get; set; } 
        #endregion
        #region Day 2
        public string Day2 { get; set; } 
        public string Day2_TimeInBed { get; set; }
        public string Day2_HowLongToSleep { get; set; }
        public string Day2_AmountOfTimesWokenUp { get; set; } 
        public string Day2_TotalTimeAwakeInNight { get; set; } 
        public string Day2_TimeWokenUpInMorning { get; set; } 
        public string Day2_TimeGottenOutOfBed { get; set; } 
        public string Day2_TotalTimeSpentInBed { get; set; } 
        public string Day2_TotalTimeSleeping { get; set; } 
        public string Day2_HowRestedDoYouFeel { get; set; }
        #endregion
        #region Day 3
        public string Day3 { get; set; } 
        public string Day3_TimeInBed { get; set; } 
        public string Day3_HowLongToSleep { get; set; } 
        public string Day3_AmountOfTimesWokenUp { get; set; } 
        public string Day3_TotalTimeAwakeInNight { get; set; } 
        public string Day3_TimeWokenUpInMorning { get; set; } 
        public string Day3_TimeGottenOutOfBed { get; set; }
        public string Day3_TotalTimeSpentInBed { get; set; }
        public string Day3_TotalTimeSleeping { get; set; } 
        public string Day3_HowRestedDoYouFeel { get; set; } 
        #endregion
        #region Day 4
        public string Day4 { get; set; } 
        public string Day4_TimeInBed { get; set; }
        public string Day4_HowLongToSleep { get; set; }
        public string Day4_AmountOfTimesWokenUp { get; set; }
        public string Day4_TotalTimeAwakeInNight { get; set; }
        public string Day4_TimeWokenUpInMorning { get; set; }
        public string Day4_TimeGottenOutOfBed { get; set; }
        public string Day4_TotalTimeSpentInBed { get; set; }
        public string Day4_TotalTimeSleeping { get; set; }
        public string Day4_HowRestedDoYouFeel { get; set; } 
        #endregion
        #region Day 5
        public string Day5 { get; set; } 
        public string Day5_TimeInBed { get; set; }
        public string Day5_HowLongToSleep { get; set; } 
        public string Day5_AmountOfTimesWokenUp { get; set; } 
        public string Day5_TotalTimeAwakeInNight { get; set; } 
        public string Day5_TimeWokenUpInMorning { get; set; } 
        public string Day5_TimeGottenOutOfBed { get; set; } 
        public string Day5_TotalTimeSpentInBed { get; set; } 
        public string Day5_TotalTimeSleeping { get; set; }
        public string Day5_HowRestedDoYouFeel { get; set; } 
        #endregion
        #region Day 6
        public string Day6 { get; set; } 
        public string Day6_TimeInBed { get; set; } 
        public string Day6_HowLongToSleep { get; set; } 
        public string Day6_AmountOfTimesWokenUp { get; set; } 
        public string Day6_TotalTimeAwakeInNight { get; set; } 
        public string Day6_TimeWokenUpInMorning { get; set; } 
        public string Day6_TimeGottenOutOfBed { get; set; } 
        public string Day6_TotalTimeSpentInBed { get; set; } 
        public string Day6_TotalTimeSleeping { get; set; } 
        public string Day6_HowRestedDoYouFeel { get; set; }
        #endregion
        #region Day 7
        public string Day7 { get; set; } 
        public string Day7_TimeInBed { get; set; } 
        public string Day7_HowLongToSleep { get; set; }
        public string Day7_AmountOfTimesWokenUp { get; set; } 
        public string Day7_TotalTimeAwakeInNight { get; set; } 
        public string Day7_TimeWokenUpInMorning { get; set; }
        public string Day7_TimeGottenOutOfBed { get; set; }
        public string Day7_TotalTimeSpentInBed { get; set; }
        public string Day7_TotalTimeSleeping { get; set; } 
        public string Day7_HowRestedDoYouFeel { get; set; }

        #endregion

        public FormSleepDiary()
        {
        }

        #region ctorp
        public FormSleepDiary(string user,
            string day1, string day1_TimeInBed, string day1_HowLongToSleep, string day1_AmountOfTimesWokenUp, string day1_TotalTimeAwakeInNight, string day1_TimeWokenUpInMorning, string day1_TimeGottenOutOfBed, string day1_TotalTimeSpentInBed, string day1_TotalTimeSleeping, string day1_HowRestedDoYouFeel, 
            string day2, string day2_TimeInBed, string day2_HowLongToSleep, string day2_AmountOfTimesWokenUp, string day2_TotalTimeAwakeInNight, string day2_TimeWokenUpInMorning, string day2_TimeGottenOutOfBed, string day2_TotalTimeSpentInBed, string day2_TotalTimeSleeping, string day2_HowRestedDoYouFeel,
            string day3, string day3_TimeInBed, string day3_HowLongToSleep, string day3_AmountOfTimesWokenUp, string day3_TotalTimeAwakeInNight, string day3_TimeWokenUpInMorning, string day3_TimeGottenOutOfBed, string day3_TotalTimeSpentInBed, string day3_TotalTimeSleeping, string day3_HowRestedDoYouFeel, 
            string day4, string day4_TimeInBed, string day4_HowLongToSleep, string day4_AmountOfTimesWokenUp, string day4_TotalTimeAwakeInNight, string day4_TimeWokenUpInMorning, string day4_TimeGottenOutOfBed, string day4_TotalTimeSpentInBed, string day4_TotalTimeSleeping, string day4_HowRestedDoYouFeel, 
            string day5, string day5_TimeInBed, string day5_HowLongToSleep, string day5_AmountOfTimesWokenUp, string day5_TotalTimeAwakeInNight, string day5_TimeWokenUpInMorning, string day5_TimeGottenOutOfBed, string day5_TotalTimeSpentInBed, string day5_TotalTimeSleeping, string day5_HowRestedDoYouFeel, 
            string day6, string day6_TimeInBed, string day6_HowLongToSleep, string day6_AmountOfTimesWokenUp, string day6_TotalTimeAwakeInNight, string day6_TimeWokenUpInMorning, string day6_TimeGottenOutOfBed, string day6_TotalTimeSpentInBed, string day6_TotalTimeSleeping, string day6_HowRestedDoYouFeel,
            string day7, string day7_TimeInBed, string day7_HowLongToSleep, string day7_AmountOfTimesWokenUp, string day7_TotalTimeAwakeInNight, string day7_TimeWokenUpInMorning, string day7_TimeGottenOutOfBed, string day7_TotalTimeSpentInBed, string day7_TotalTimeSleeping, string day7_HowRestedDoYouFeel)
        {
            UserEmail = user;
            Day1 = day1;
            Day1_TimeInBed = day1_TimeInBed;
            Day1_HowLongToSleep = day1_HowLongToSleep;
            Day1_AmountOfTimesWokenUp = day1_AmountOfTimesWokenUp;
            Day1_TotalTimeAwakeInNight = day1_TotalTimeAwakeInNight;
            Day1_TimeWokenUpInMorning = day1_TimeWokenUpInMorning;
            Day1_TimeGottenOutOfBed = day1_TimeGottenOutOfBed;
            Day1_TotalTimeSpentInBed = day1_TotalTimeSpentInBed;
            Day1_TotalTimeSleeping = day1_TotalTimeSleeping;
            Day1_HowRestedDoYouFeel = day1_HowRestedDoYouFeel;
            Day2 = day2;
            Day2_TimeInBed = day2_TimeInBed;
            Day2_HowLongToSleep = day2_HowLongToSleep;
            Day2_AmountOfTimesWokenUp = day2_AmountOfTimesWokenUp;
            Day2_TotalTimeAwakeInNight = day2_TotalTimeAwakeInNight;
            Day2_TimeWokenUpInMorning = day2_TimeWokenUpInMorning;
            Day2_TimeGottenOutOfBed = day2_TimeGottenOutOfBed;
            Day2_TotalTimeSpentInBed = day2_TotalTimeSpentInBed;
            Day2_TotalTimeSleeping = day2_TotalTimeSleeping;
            Day2_HowRestedDoYouFeel = day2_HowRestedDoYouFeel;
            Day3 = day3;
            Day3_TimeInBed = day3_TimeInBed;
            Day3_HowLongToSleep = day3_HowLongToSleep;
            Day3_AmountOfTimesWokenUp = day3_AmountOfTimesWokenUp;
            Day3_TotalTimeAwakeInNight = day3_TotalTimeAwakeInNight;
            Day3_TimeWokenUpInMorning = day3_TimeWokenUpInMorning;
            Day3_TimeGottenOutOfBed = day3_TimeGottenOutOfBed;
            Day3_TotalTimeSpentInBed = day3_TotalTimeSpentInBed;
            Day3_TotalTimeSleeping = day3_TotalTimeSleeping;
            Day3_HowRestedDoYouFeel = day3_HowRestedDoYouFeel;
            Day4 = day4;
            Day4_TimeInBed = day4_TimeInBed;
            Day4_HowLongToSleep = day4_HowLongToSleep;
            Day4_AmountOfTimesWokenUp = day4_AmountOfTimesWokenUp;
            Day4_TotalTimeAwakeInNight = day4_TotalTimeAwakeInNight;
            Day4_TimeWokenUpInMorning = day4_TimeWokenUpInMorning;
            Day4_TimeGottenOutOfBed = day4_TimeGottenOutOfBed;
            Day4_TotalTimeSpentInBed = day4_TotalTimeSpentInBed;
            Day4_TotalTimeSleeping = day4_TotalTimeSleeping;
            Day4_HowRestedDoYouFeel = day4_HowRestedDoYouFeel;
            Day5 = day5;
            Day5_TimeInBed = day5_TimeInBed;
            Day5_HowLongToSleep = day5_HowLongToSleep;
            Day5_AmountOfTimesWokenUp = day5_AmountOfTimesWokenUp;
            Day5_TotalTimeAwakeInNight = day5_TotalTimeAwakeInNight;
            Day5_TimeWokenUpInMorning = day5_TimeWokenUpInMorning;
            Day5_TimeGottenOutOfBed = day5_TimeGottenOutOfBed;
            Day5_TotalTimeSpentInBed = day5_TotalTimeSpentInBed;
            Day5_TotalTimeSleeping = day5_TotalTimeSleeping;
            Day5_HowRestedDoYouFeel = day5_HowRestedDoYouFeel;
            Day6 = day6;
            Day6_TimeInBed = day6_TimeInBed;
            Day6_HowLongToSleep = day6_HowLongToSleep;
            Day6_AmountOfTimesWokenUp = day6_AmountOfTimesWokenUp;
            Day6_TotalTimeAwakeInNight = day6_TotalTimeAwakeInNight;
            Day6_TimeWokenUpInMorning = day6_TimeWokenUpInMorning;
            Day6_TimeGottenOutOfBed = day6_TimeGottenOutOfBed;
            Day6_TotalTimeSpentInBed = day6_TotalTimeSpentInBed;
            Day6_TotalTimeSleeping = day6_TotalTimeSleeping;
            Day6_HowRestedDoYouFeel = day6_HowRestedDoYouFeel;
            Day7 = day7;
            Day7_TimeInBed = day7_TimeInBed;
            Day7_HowLongToSleep = day7_HowLongToSleep;
            Day7_AmountOfTimesWokenUp = day7_AmountOfTimesWokenUp;
            Day7_TotalTimeAwakeInNight = day7_TotalTimeAwakeInNight;
            Day7_TimeWokenUpInMorning = day7_TimeWokenUpInMorning;
            Day7_TimeGottenOutOfBed = day7_TimeGottenOutOfBed;
            Day7_TotalTimeSpentInBed = day7_TotalTimeSpentInBed;
            Day7_TotalTimeSleeping = day7_TotalTimeSleeping;
            Day7_HowRestedDoYouFeel = day7_HowRestedDoYouFeel;
        }
        #endregion

        public override string ToString()
        {
            return
                $"Day 1: {Day1} \n" +
                $"Time in bed: {Day1_TimeInBed} \n" +
                $"How long to sleep: {Day1_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day1_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day1_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day1_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day1_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day1_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day1_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day1_HowRestedDoYouFeel} \n\n" +
                $"Day 2: {Day2} \n" +
                $"Time in bed: {Day2_TimeInBed} \n" +
                $"How long to sleep: {Day2_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day2_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day2_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day2_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day2_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day2_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day2_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day2_HowRestedDoYouFeel} \n\n" +
                $"Day 3: {Day3} \n" +
                $"Time in bed: {Day3_TimeInBed} \n" +
                $"How long to sleep: {Day3_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day3_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day3_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day3_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day3_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day3_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day3_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day3_HowRestedDoYouFeel} \n\n" +
                $"Day 4: {Day4} \n" +
                $"Time in bed: {Day4_TimeInBed} \n" +
                $"How long to sleep: {Day4_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day4_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day4_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day4_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day4_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day4_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day4_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day4_HowRestedDoYouFeel} \n\n" +
                $"Day 5: {Day5} \n" +
                $"Time in bed: {Day5_TimeInBed} \n" +
                $"How long to sleep: {Day5_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day5_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day5_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day5_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day5_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day5_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day5_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day5_HowRestedDoYouFeel} \n\n" +
                $"Day 6: {Day6} \n" +
                $"Time in bed: {Day6_TimeInBed} \n" +
                $"How long to sleep: {Day6_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day6_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day6_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day6_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day6_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day6_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day6_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day6_HowRestedDoYouFeel} \n\n" +
                $"Day 7: {Day7} \n" +
                $"Time in bed: {Day7_TimeInBed} \n" +
                $"How long to sleep: {Day7_HowLongToSleep} \n" +
                $"Amount of times woken up: {Day7_AmountOfTimesWokenUp} \n" +
                $"Total time awake in night: {Day7_TotalTimeAwakeInNight} \n" +
                $"Time woken up in morning: {Day7_TimeWokenUpInMorning} \n" +
                $"Time gotten out of bed: {Day7_TimeGottenOutOfBed} \n" +
                $"Total time spent in bed: {Day7_TotalTimeSpentInBed} \n" +
                $"Total time sleeping: {Day7_TotalTimeSleeping} \n" +
                $"How rested do you feel: {Day7_HowRestedDoYouFeel} \n\n";
                    

        }
    }
}
