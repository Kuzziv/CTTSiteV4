using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTTSite.Models.Forms;
using CTTSite.Services.Interface;

// Made by Christian

namespace CTTSite.Pages.Forms
{
    public class FormsMenuPageModel : PageModel
    {
        private IFormService _formService;
        
        public FormActivityDiary formActivityDiary { get; set; }
        public FormActivityList formActivityList { get; set; }
        public FormActivitySchedule formActivitySchedule { get; set; }
        public FormHotCrossBun formHotCrossBun { get; set; }
        public FormSleepDiary formSleepDiary { get; set; }


        public FormsMenuPageModel(IFormService formService)
        {
            _formService = formService;

        }

        public void OnGet()
        {
            if (_formService.GetFormActivityDiaryByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivityDiary = _formService.GetFormActivityDiaryByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                formActivityDiary = null;
            }

            if (_formService.GetFormActivityListByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivityList = _formService.GetFormActivityListByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                formActivityList = null;
            }

            if (_formService.GetFormActivityScheduleByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formActivitySchedule = _formService.GetFormActivityScheduleByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                formActivitySchedule = null;
            }

            if (_formService.GetFormHotCrossBunByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formHotCrossBun = _formService.GetFormHotCrossBunByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                formHotCrossBun = null;
            }

            if (_formService.GetFormSleepDiaryByUserEmail(HttpContext.User.Identity.Name) != null)
            {
                formSleepDiary = _formService.GetFormSleepDiaryByUserEmail(HttpContext.User.Identity.Name);
            }
            else
            {
                formSleepDiary = null;
            }           
        }
    }
}
