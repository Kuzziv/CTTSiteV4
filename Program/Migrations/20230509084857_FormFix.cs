using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTTSite.Migrations
{
    /// <inheritdoc />
    public partial class FormFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormActivityDiaries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_0600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_0700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_0800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_0900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1400 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1500 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1600 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1700 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_1900 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_2000 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_2100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_2200 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_2300 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_2400 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormActivityDiaries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FormActivityLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pleasure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achievement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Social = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormActivityLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FormActivitySchedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Morning7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afternoon7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score7 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormActivitySchedules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FormHotCrossBuns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trigger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thoughts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emotions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Behaviours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Physical = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormHotCrossBuns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FormSleepDiaries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day1_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day2_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day3_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day4_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day5_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day6_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TimeInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_HowLongToSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_AmountOfTimesWokenUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TotalTimeAwakeInNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TimeWokenUpInMorning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TimeGottenOutOfBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TotalTimeSpentInBed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_TotalTimeSleeping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day7_HowRestedDoYouFeel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSleepDiaries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IMG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Staff = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ItemID",
                table: "CartItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserID",
                table: "CartItems",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "FormActivityDiaries");

            migrationBuilder.DropTable(
                name: "FormActivityLists");

            migrationBuilder.DropTable(
                name: "FormActivitySchedules");

            migrationBuilder.DropTable(
                name: "FormHotCrossBuns");

            migrationBuilder.DropTable(
                name: "FormSleepDiaries");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
