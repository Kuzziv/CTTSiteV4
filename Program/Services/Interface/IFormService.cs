using CTTSite.Models;
using CTTSite.Models.Forms;

// Made by Christian

namespace CTTSite.Services.Interface
{
    public interface IFormService
    {

        #region Activity Diary

        FormActivityDiary GetFormActivityDiaryById(int id);


        FormActivityDiary GetFormActivityDiaryByUserEmail(string email);


        Task CreateFormActivityDiary(FormActivityDiary form);


        Task UpdateFormActivityDiary(FormActivityDiary formN);


        Task DeleteFormActivityDiary(FormActivityDiary form);


        Task SubmitFormActivityDiary(FormActivityDiary form, string email);

        #endregion

        #region Activity List


        FormActivityList GetFormActivityListById(int id);

        FormActivityList GetFormActivityListByUserEmail(string email);


        Task CreateFormActivityList(FormActivityList form);


        Task UpdateFormActivityList(FormActivityList formN);


        Task DeleteFormActivityList(FormActivityList form);


        Task SubmitFormActivityList(FormActivityList form, string email);

        #endregion

        #region Activity Schedule
        FormActivitySchedule GetFormActivityScheduleById(int id);


        FormActivitySchedule GetFormActivityScheduleByUserEmail(string email);


        Task CreateFormActivitySchedule(FormActivitySchedule form);


        Task UpdateFormActivitySchedule(FormActivitySchedule formN);


        Task DeleteFormActivitySchedule(FormActivitySchedule form);


        Task SubmitFormActivitySchedule(FormActivitySchedule form, string email);

        #endregion

        #region Hot Cross Bun
        FormHotCrossBun GetFormHotCrossBunById(int id);


        FormHotCrossBun GetFormHotCrossBunByUserEmail(string email);


        Task CreateFormHotCrossBun(FormHotCrossBun form);


        Task UpdateFormHotCrossBun(FormHotCrossBun formN);


        Task DeleteFormHotCrossBun(FormHotCrossBun form);


        Task SubmitFormHotCrossBun(FormHotCrossBun form, string email);

        #endregion

        #region Sleep Diary
        FormSleepDiary GetFormSleepDiaryById(int id);


        FormSleepDiary GetFormSleepDiaryByUserEmail(string email);


        Task CreateFormSleepDiary(FormSleepDiary form);


        Task UpdateFormSleepDiary(FormSleepDiary formN);


        Task DeleteFormSleepDiary(FormSleepDiary form);


        Task SubmitFormSleepDiary(FormSleepDiary form, string email);
       
        #endregion


    }
}
