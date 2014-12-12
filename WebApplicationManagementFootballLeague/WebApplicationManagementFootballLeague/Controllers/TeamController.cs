using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationManagementFootballLeague.Models;
using WebApplicationManagementFootballLeague.Models.ModelsView;

namespace WebApplicationManagementFootballLeague.Controllers
{
    public class TeamController : Controller
    {
        private BaseSZLPEntities db = new BaseSZLPEntities();


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
                Session["ID_team"] = ID;
            }
            else
            {
                id = System.Convert.ToInt16(ID);
                Session["ID_team"] = ID;
            }
            teamModelView.team = db.TEAMs.Find(id);
            return PartialView("~/Views/Partial/Team/_TeamInfoPartial.cshtml", teamModelView);
        }
        public PartialViewResult ShowTeamNews(string ID)
        {
            NEWS zz = new NEWS();
            List<NEWS> list = new List<NEWS>();
            int id;
            int i = 1;
            if (ID == null)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt16(Session["ID_team"]);
            }
            var result = db.newsForTheTeam(id).ToList();
            foreach (var x in result)
            {
                zz = new NEWS();
                zz.title = x.title;
                zz.text = x.text;
                zz.date = x.date;
                list.Add(zz);
            }
            teamModelView.listOfNews = list;
            //teamModelView.listOfNews = db.newsForTheTeam(id).ToList();
            return PartialView("~/Views/Partial/Team/_TeamNewsPartial.cshtml", teamModelView);
        }
        public PartialViewResult ShowTeamMatches(string ID)
        {
            return PartialView("~/Views/Partial/Team/_TeamMatchesPartial.cshtml", teamModelView);
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
                db.Entry(team).State = EntityState.Modified;
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