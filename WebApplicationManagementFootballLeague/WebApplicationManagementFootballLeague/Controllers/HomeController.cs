using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ID)
        {
            return View();
        }

        public ActionResult ShowTeamNews()
        {
            return PartialView("~/Views/Partial/Team/_TeamNewsPartial.cshtml");
        }

        public ActionResult ShowTeamFootball()
        {
            return PartialView("~/Views/Partial/Team/_TeamFootballPartial.cshtml");
        }

        public ActionResult ShowTeamTimetable()
        {
            return PartialView("~/Views/Partial/Team/_TeamTimetablePartial.cshtml");
        }

        public ActionResult ShowTeamInfo()
        {
            return RedirectToAction("ShowTeamInfo", "Team");
        }

        public ActionResult ShowTeamContact()
        {
            return PartialView("~/Views/Partial/Team/_TeamContactPartial.cshtml");
        }
    }
}
