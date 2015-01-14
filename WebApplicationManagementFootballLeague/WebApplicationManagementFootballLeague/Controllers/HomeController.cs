using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace WebApplicationManagementFootballLeague.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }
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
            return RedirectToAction("ShowTeamNews", "Team");
        }
        public ActionResult ShowTeamNewsByID()
        {
            return RedirectToAction("ShowTeamNewsByID", "Team");
        }

        public ActionResult ShowTeamStaff()
        {
            return RedirectToAction("ShowTeamStaff", "Team");
        }

        public ActionResult ShowTeamTimetable()
        {
            return RedirectToAction("ShowTeamTimeTable", "Team");
        }
        public ActionResult ShowTeamtable()
        {
            return RedirectToAction("ShowTeamTable", "Team");
        }

        public ActionResult ShowTeamInfo()
        {
            return RedirectToAction("ShowTeamInfo", "Team");
        }

        public ActionResult ShowTeamContact()
        {
            return RedirectToAction("ShowTeamContact", "Team");
        }
    }
}
