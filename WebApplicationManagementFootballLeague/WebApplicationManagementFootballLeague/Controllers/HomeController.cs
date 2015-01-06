using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["ID_team"] = "1";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ID)
        {
            Session["ID_team"] = "1";
            return View();
        }

        public ActionResult ShowTeamNews()
        {
            return PartialView("~/Views/Partial/Team/_TeamNewsPartial.cshtml");
        }

        public ActionResult ShowTeamStaff()
        {
            return RedirectToAction("ShowTeamStaff", "Team");
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
