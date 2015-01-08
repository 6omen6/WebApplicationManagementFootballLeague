using Facebook;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationManagementFootballLeague.Models;
using WebApplicationManagementFootballLeague.Models.ModelsView;
using WebApplicationManagementFootballLeague.Repository;
using WebMatrix.WebData;

namespace WebApplicationManagementFootballLeague.Controllers
{
    public class TeamController : Controller
    {
        private BaseSZLPEntities db = new BaseSZLPEntities();
        private TeamRepository teamRepository = new TeamRepository();


        TeamModelView teamModelView = new TeamModelView();
        //
        // GET: /Team/

        public ActionResult Index()
        {
            return View(db.TEAMs.ToList());
        }

        //
        // GET: /Team/Details/5
        public ActionResult ShowHeader(int id = 1)
        {
            if (Session["Token"] != null)
            {
                var idd = WebSecurity.GetUserId(User.Identity.Name);
                teamModelView.profile = teamRepository.GetUserByID(idd);
                var client = new FacebookClient(HttpContext.Session["Token"].ToString());

                dynamic fbresult = client.Get("me/picture?fields=url&redirect=false");
                var data = fbresult["data"];
                fbresult = client.Get("me?fields=first_name,last_name,location");
                var first_name = fbresult["first_name"];
                var last_name = fbresult["last_name"];
                var location = fbresult["location"];

                teamModelView.profile.firstName = first_name;
                teamModelView.profile.lastName = last_name;
                teamModelView.profile.avatar = data["url"];
            }
            else if (WebSecurity.IsAuthenticated && Session["Token"] == null)
            {
                var idd = WebSecurity.GetUserId(User.Identity.Name);
                teamModelView.profile = teamRepository.GetUserByID(idd);
            }

            teamModelView.listOfTeams = db.TEAMs.ToList();
            if (teamModelView.listOfTeams == null)
            {
                return HttpNotFound();
            }
            return PartialView("~/Views/Partial/Header/_HeaderMenuPartial.cshtml", teamModelView);
        }

        public PartialViewResult ShowTeamInfo(string ID)
        {
            int id;
            if (ID == null)
            {
                id = 1;
                Session["ID_team"] = "1";
            }
            else
            {
                id = System.Convert.ToInt16(ID);
                Session["ID_team"] = ID;
            }
            teamModelView.listOfPresidents = teamRepository.StaffInTeamByRole(id, "Prezes zarządu");
            teamModelView.listOfVPresidents = teamRepository.StaffInTeamByRole(id, "Zastępca prezesa");
            teamModelView.listOfManagers = teamRepository.StaffInTeamByRole(id, "Manager");
            teamModelView.listOfCoaches = teamRepository.StaffInTeamByRole(id, "Trener");
            teamModelView.team = db.TEAMs.Find(id);
            teamModelView.ID_team = id;
            return PartialView("~/Views/Partial/Team/_TeamInfoPartial.cshtml", teamModelView);
        }

        public PartialViewResult ShowTeamStaff(string ID)
        {
            int id;
            if (ID == null)
            {
                id = 1;
                Session["ID_team"] = "1";
            }
            else
            {
                id = System.Convert.ToInt16(ID);
                Session["ID_team"] = ID;
            }
            teamModelView.listOfPresidents = teamRepository.StaffInTeamByRole(id, "Prezes zarządu");
            teamModelView.listOfVPresidents = teamRepository.StaffInTeamByRole(id, "Zastępca prezesa");
            teamModelView.listOfManagers = teamRepository.StaffInTeamByRole(id, "Manager");
            teamModelView.listOfCoaches = teamRepository.StaffInTeamByRole(id, "Trener");
            teamModelView.listOfPlayers = teamRepository.GetPlayersByID(id);
            teamModelView.team = db.TEAMs.Find(id);
            return PartialView("~/Views/Partial/Team/_TeamStaffPartial.cshtml", teamModelView);
        }

        public PartialViewResult ShowTeamNews(string ID)
        {
            int id;
            if (ID == null)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt16(Session["ID_team"]);
            }
            teamModelView.listOfNews = teamRepository.ListOfNews(id);
            //teamModelView.listOfNews = db.newsForTheTeam(id).ToList();
            return PartialView("~/Views/Partial/Team/_TeamNewsPartial.cshtml", teamModelView);
        }
        public PartialViewResult ShowTeamMatches(string ID)
        {
            return PartialView("~/Views/Partial/Team/_TeamMatchesPartial.cshtml", teamModelView);
        }
        public PartialViewResult ShowTeamTimeTable(string ID)
        {
            teamModelView.listOfScheduleofMatches = teamRepository.schleduleOfMatches();
            teamModelView.ID_team = System.Convert.ToInt16(Session["ID_team"]);
            return PartialView("~/Views/Partial/Team/_TeamTimeTablePartial.cshtml", teamModelView);
        }

        public PartialViewResult ShowTableMini()
        {
            teamModelView.listOfTeams = db.TEAMs.ToList();
            return PartialView("~/Views/Partial/Table/_TableMiniPartial.cshtml", teamModelView);
        }
        //
        // GET: /Team/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Team/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TEAM team)
        {
            if (ModelState.IsValid)
            {
                db.TEAMs.Add(team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team);
        }

        //
        // GET: /Team/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TEAM team = db.TEAMs.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        //
        // POST: /Team/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TEAM team)
        {
            if (ModelState.IsValid)
            {
                db.Entry(team).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        //
        // GET: /Team/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TEAM team = db.TEAMs.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        //
        // POST: /Team/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TEAM team = db.TEAMs.Find(id);
            db.TEAMs.Remove(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}