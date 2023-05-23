using CTTSite.Models;
using CTTSite.Models.Forms;
using CTTSite.Pages.TheRoomBooking;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

// Made by Christian

namespace CTTSite.Services.NormalService
{

    /// <summary>
    ///  This class is used to handle all form related functions.
    /// </summary>
    public class FormService : IFormService
    {       
        private DBServiceGeneric<FormActivityDiary> _activityDiaryService;
        private DBServiceGeneric<FormActivityList> _activityListService;
        private DBServiceGeneric<FormActivitySchedule> _activityScheduleService;
        private DBServiceGeneric<FormHotCrossBun> _hotCrossBunService;
        private DBServiceGeneric<FormSleepDiary> _sleepDiaryService;
        private IEmailService _emailService;


        /// <summary>
        ///  These lists are used to store the forms from the database.
        /// </summary>
        private List<FormActivityDiary> _activityDiaries { get; set; }
        private List<FormActivityList> _activityLists { get; set; }
        private List<FormActivitySchedule> _activitySchedules { get; set; }
        private List<FormHotCrossBun> _hotCrossBuns { get; set; }
        private List<FormSleepDiary> _sleepDiaries { get; set; }



        public FormService(DBServiceGeneric<FormActivityDiary> activityDiaryService, DBServiceGeneric<FormActivityList> activityListService, DBServiceGeneric<FormActivitySchedule> activityScheduleService, DBServiceGeneric<FormHotCrossBun> hotCrossBunService, DBServiceGeneric<FormSleepDiary> sleepDiaryService, IEmailService emailService)
        {
            _activityDiaryService = activityDiaryService;
            _activityListService = activityListService;
            _activityScheduleService = activityScheduleService;
            _hotCrossBunService = hotCrossBunService;
            _sleepDiaryService = sleepDiaryService;
            _emailService = emailService;

            _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();
            _activityLists = _activityListService.GetObjectsAsync().Result.ToList();
            _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();
            _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();
            _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();

        }


        #region Activity Diary
        /// <summary>
        ///  This method is used to get an activity diary from the list of activity diaries via it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FormActivityDiary</returns>
        public FormActivityDiary GetFormActivityDiaryById(int id)
        {
            _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();
            FormActivityDiary form;

            foreach (FormActivityDiary formActivityDiary in _activityDiaries)
            {
                if (formActivityDiary.ID == id)
                {
                    form = formActivityDiary;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        /// This method is used to get an activity diary from the list of activity diaries via it's User Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>FormActivityDiary</returns>
        public FormActivityDiary GetFormActivityDiaryByUserEmail(string email)
        {
            _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();
            FormActivityDiary form;

            foreach (FormActivityDiary formActivityDiary in _activityDiaries)
            {
                if (formActivityDiary.UserEmail == email)
                {
                    form = formActivityDiary;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        /// This method is used to create a new FormActivityDiary and add it to the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task CreateFormActivityDiary(FormActivityDiary form)
        {
            _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();
            _activityDiaries.Add(form);
            await _activityDiaryService.AddObjectAsync(form);
        }

        /// <summary>
        /// This method is used to update an existing FormActivityDiary in the list and database.
        /// </summary>
        /// <param name="formN"></param>
        /// <returns>Void</returns>
        public async Task UpdateFormActivityDiary(FormActivityDiary formN)
        {
            if (formN != null)
            {
                FormActivityDiary formO = GetFormActivityDiaryByUserEmail(formN.UserEmail);
                if (formO != null)
                {

                    formN.ID = formO.ID;
                    formN.UserEmail = formO.UserEmail;

                    formO = formN;

                    await _activityDiaryService.UpdateObjectAsync(formO);
                    _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();

                }

            }

        }


        /// <summary>
        /// This method is used to delete an existing FormActivityDiary from the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task DeleteFormActivityDiary(FormActivityDiary form)
        {

            if (form != null)
            {

                await _activityDiaryService.DeleteObjectAsync(form);
                _activityDiaries = _activityDiaryService.GetObjectsAsync().Result.ToList();
            }

        }

        /// <summary>
        /// This method is used to submit an existing FormActivityDiary and send it to the user and admin email.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="email"></param>
        /// <returns>Void</returns>
        public async Task SubmitFormActivityDiary(FormActivityDiary form, string email)
        {
            _emailService.SendEmail(new Email(form.ToString(), "Activity Diary: " + email, email));
            
            //The line of code under this comment is commented out as this sends a mail to the PO with the form and we would like to avoid spam in her inbox while the application is being tested. This email does work and sends a copy of the form to the customer and the PO.  
            //_emailService.SendEmail(new Email(form.ToString(), "Activity Diary: " + email, "chilterntalkingtherapies@gmail.com"));
            await DeleteFormActivityDiary(form);
        }
        #endregion

        #region Activity List

        /// <summary>
        ///  This method is used to get an activity list from the list of activity lists via it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FormActivityList</returns>
        public FormActivityList GetFormActivityListById(int id)
        {
            _activityLists = _activityListService.GetObjectsAsync().Result.ToList();
            FormActivityList form;

            foreach (FormActivityList formActivityList in _activityLists)
            {
                if (formActivityList.ID == id)
                {
                    form = formActivityList;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        /// This method is used to get an activity list from the list of activity lists via it's User Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>FormActivityList</returns>
        public FormActivityList GetFormActivityListByUserEmail(string email)
        {
            _activityLists = _activityListService.GetObjectsAsync().Result.ToList();
            FormActivityList form;

            foreach (FormActivityList formActivityList in _activityLists)
            {
                if (formActivityList.UserEmail == email)
                {
                    form = formActivityList;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to create a new FormActivityList and add it to the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task CreateFormActivityList(FormActivityList form)
        {
            _activityLists = _activityListService.GetObjectsAsync().Result.ToList();
            _activityLists.Add(form);
            await _activityListService.AddObjectAsync(form);
        }

        public async Task UpdateFormActivityList(FormActivityList formN)
        {
            if (formN != null)
            {
                FormActivityList formO = GetFormActivityListByUserEmail(formN.UserEmail);
                if (formO != null)
                {

                    formN.ID = formO.ID;
                    formN.UserEmail = formO.UserEmail;

                    formO = formN;

                    await _activityListService.UpdateObjectAsync(formO);
                    _activityLists = _activityListService.GetObjectsAsync().Result.ToList();

                }

            }

        }

        /// <summary>
        ///  This method is used to delete an existing FormActivityList from the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task DeleteFormActivityList(FormActivityList form)
        {

            if (form != null)
            {

                await _activityListService.DeleteObjectAsync(form);
                _activityLists = _activityListService.GetObjectsAsync().Result.ToList();
            }

        }

        /// <summary>
        /// This method is used to submit an existing FormActivityList and send it to the user and admin email.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="email"></param>
        /// <returns>Void</returns>
        public async Task SubmitFormActivityList(FormActivityList form, string email)
        {
            _emailService.SendEmail(new Email(form.ToString(), "Activity List: " + email, email));

            //The line of code under this comment is commented out as this sends a mail to the PO with the form and we would like to avoid spam in her inbox while the application is being tested. This email does work and sends a copy of the form to the customer and the PO.
            //_emailService.SendEmail(new Email(form.ToString(), "Activity List: " + email, "chilterntalkingtherapies@gmail.com"));
            await DeleteFormActivityList(form);
        }
        #endregion

        #region Activity Schedule

        /// <summary>
        ///  This method is used to get an activity schedule from the list of activity schedules via it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FormActivityList</returns>
        public FormActivitySchedule GetFormActivityScheduleById(int id)
        {
            _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();
            FormActivitySchedule form;

            foreach (FormActivitySchedule formActivitySchedule in _activitySchedules)
            {
                if (formActivitySchedule.ID == id)
                {
                    form = formActivitySchedule;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to get an activity schedule from the list of activity schedules via it's User Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>FormActivityList</returns>
        public FormActivitySchedule GetFormActivityScheduleByUserEmail(string email)
        {
            _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();
            FormActivitySchedule form;

            foreach (FormActivitySchedule formActivitySchedule in _activitySchedules)
            {
                if (formActivitySchedule.UserEmail == email)
                {
                    form = formActivitySchedule;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to create a new FormActivitySchedule and add it to the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task CreateFormActivitySchedule(FormActivitySchedule form)
        {
            _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();
            _activitySchedules.Add(form);
            await _activityScheduleService.AddObjectAsync(form);
        }

        /// <summary>
        ///  This method is used to update an existing FormActivitySchedule and update it in the list and database.
        /// </summary>
        /// <param name="formN"></param>
        /// <returns>Void</returns>
        public async Task UpdateFormActivitySchedule(FormActivitySchedule formN)
        {
            if (formN != null)
            {
                FormActivitySchedule formO = GetFormActivityScheduleByUserEmail(formN.UserEmail);
                if (formO != null)
                {

                    formN.ID = formO.ID;
                    formN.UserEmail = formO.UserEmail;

                    formO = formN;

                    await _activityScheduleService.UpdateObjectAsync(formO);
                    _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();

                }

            }

        }

        /// <summary>
        ///  This method is used to delete an existing FormActivitySchedule from the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task DeleteFormActivitySchedule(FormActivitySchedule form)
        {

            if (form != null)
            {

                await _activityScheduleService.DeleteObjectAsync(form);
                _activitySchedules = _activityScheduleService.GetObjectsAsync().Result.ToList();
            }

        }

        /// <summary>
        ///  This method is used to submit an existing FormActivitySchedule and send it to the user and admin email.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="email"></param>
        /// <returns>Void</returns>
        public async Task SubmitFormActivitySchedule(FormActivitySchedule form, string email)
        {
            _emailService.SendEmail(new Email(form.ToString(), "Activity Schedule: " + email, email));

            //The line of code under this comment is commented out as this sends a mail to the PO with the form and we would like to avoid spam in her inbox while the application is being tested. This email does work and sends a copy of the form to the customer and the PO.
            //_emailService.SendEmail(new Email(form.ToString(), "Activity Schedule: " + email, "chilterntalkingtherapies@gmail.com"));
            await DeleteFormActivitySchedule(form);
        }
        #endregion

        #region Hot Cross Bun

        /// <summary>
        ///  This method is used to get a hot cross bun from the list of hot cross buns via it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FormHotCrossBun</returns>
        public FormHotCrossBun GetFormHotCrossBunById(int id)
        {
            _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();
            FormHotCrossBun form;

            foreach (FormHotCrossBun formHotCrossBun in _hotCrossBuns)
            {
                if (formHotCrossBun.ID == id)
                {
                    form = formHotCrossBun;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to get a hot cross bun from the list of hot cross buns via it's User Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>FormHotCrossBun</returns>
        public FormHotCrossBun GetFormHotCrossBunByUserEmail(string email)
        {
            _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();
            FormHotCrossBun form;

            foreach (FormHotCrossBun formHotCrossBun in _hotCrossBuns)
            {
                if (formHotCrossBun.UserEmail == email)
                {
                    form = formHotCrossBun;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        /// This method is used to create a new FormHotCrossBun and add it to the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task CreateFormHotCrossBun(FormHotCrossBun form)
        {
            _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();
            _hotCrossBuns.Add(form);
            await _hotCrossBunService.AddObjectAsync(form);
        }

        /// <summary>
        ///  This method is used to update an existing FormHotCrossBun and update it in the list and database.
        /// </summary>
        /// <param name="formN"></param>
        /// <returns>Void</returns>
        public async Task UpdateFormHotCrossBun(FormHotCrossBun formN)
        {
            if (formN != null)
            {
                FormHotCrossBun formO = GetFormHotCrossBunByUserEmail(formN.UserEmail);
                if (formO != null)
                {

                    formN.ID = formO.ID;
                    formN.UserEmail = formO.UserEmail;

                    formO = formN;

                    await _hotCrossBunService.UpdateObjectAsync(formO);
                    _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();

                }

            }

        }

        /// <summary>
        ///  This method is used to delete an existing FormHotCrossBun from the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task DeleteFormHotCrossBun(FormHotCrossBun form)
        {
            
            if (form != null)
            {
                
                await _hotCrossBunService.DeleteObjectAsync(form);
                _hotCrossBuns = _hotCrossBunService.GetObjectsAsync().Result.ToList();
            }
            
        }

        /// <summary>
        ///  This method is used to submit an existing FormHotCrossBun and send it to the user and admin email.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="email"></param>
        /// <returns>Void</returns>
        public async Task SubmitFormHotCrossBun(FormHotCrossBun form, string email)
        {
            _emailService.SendEmail(new Email(form.ToString(), "Hot Cross Bun: " + email, email));

            //The line of code under this comment is commented out as this sends a mail to the PO with the form and we would like to avoid spam in her inbox while the application is being tested. This email does work and sends a copy of the form to the customer and the PO.
            //_emailService.SendEmail(new Email(form.ToString(), "Hot Cross Bun: " + email, "chilterntalkingtherapies@gmail.com"));
            await DeleteFormHotCrossBun(form);            
        }
        #endregion

        #region Sleep Diary

        /// <summary>
        ///  This method is used to create a new FormSleepDiary and add it to the list and database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FormSleepDiary</returns>
        public FormSleepDiary GetFormSleepDiaryById(int id)
        {
            _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();
            FormSleepDiary form;

            foreach (FormSleepDiary formSleepDiary in _sleepDiaries)
            {
                if (formSleepDiary.ID == id)
                {
                    form = formSleepDiary;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to get a sleep diary from the list of sleep diaries via it's User Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>FormSleepDiary</returns>
        public FormSleepDiary GetFormSleepDiaryByUserEmail(string email)
        {
            _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();
            FormSleepDiary form;

            foreach (FormSleepDiary formSleepDiary in _sleepDiaries)
            {
                if (formSleepDiary.UserEmail == email)
                {
                    form = formSleepDiary;
                    return form;
                }
            }
            return null;
        }

        /// <summary>
        ///  This method is used to create a new FormSleepDiary and add it to the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task CreateFormSleepDiary(FormSleepDiary form)
        {
            _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();
            _sleepDiaries.Add(form);
            await _sleepDiaryService.AddObjectAsync(form);
        }

        /// <summary>
        ///  This method is used to update an existing FormSleepDiary and update it in the list and database.
        /// </summary>
        /// <param name="formN"></param>
        /// <returns>Void</returns>
        public async Task UpdateFormSleepDiary(FormSleepDiary formN)
        {
            if (formN != null)
            {
                FormSleepDiary formO = GetFormSleepDiaryByUserEmail(formN.UserEmail);
                if (formO != null)
                {

                    formN.ID = formO.ID;
                    formN.UserEmail = formO.UserEmail;

                    formO = formN;

                    await _sleepDiaryService.UpdateObjectAsync(formO);
                    _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();

                }

            }

        }


        /// <summary>
        ///  This method is used to delete an existing FormSleepDiary from the list and database.
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Void</returns>
        public async Task DeleteFormSleepDiary(FormSleepDiary form)
        {

            if (form != null)
            {

                await _sleepDiaryService.DeleteObjectAsync(form);
                _sleepDiaries = _sleepDiaryService.GetObjectsAsync().Result.ToList();
            }

        }

        /// <summary>
        ///  This method is used to submit an existing FormSleepDiary and send it to the user and admin email.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="email"></param>
        /// <returns>Void</returns>
        public async Task SubmitFormSleepDiary(FormSleepDiary form, string email)
        {
            _emailService.SendEmail(new Email(form.ToString(), "Sleep Diary: " + email, email));

            //The line of code under this comment is commented out as this sends a mail to the PO with the form and we would like to avoid spam in her inbox while the application is being tested. This email does work and sends a copy of the form to the customer and the PO.
            //_emailService.SendEmail(new Email(form.ToString(), "Sleep Diary: " + email, "chilterntalkingtherapies@gmail.com"));
            await DeleteFormSleepDiary(form);
        }
        #endregion
    }
}
