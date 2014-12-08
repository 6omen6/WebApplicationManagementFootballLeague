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
            return View(db.TEAM.ToList());
        }

        //
        // GET: /Team/Details/5
        public ActionResult ShowHeader(int id = 1)
        {
            teamModelView.listOfTeams = db.TEAM.ToList();
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
            }
            else
            {
                id = System.Convert.ToInt16(ID);
            }
            teamModelView.team = db.TEAM.Find(id);
            return PartialView("~/Views/Partial/Team/_TeamInfoPartial.cshtml", teamModelView);
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
                db.TEAM.Add(team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team);
        }

        //
        // GET: /Team/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TEAM team = db.TEAM.Find(id);
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
            TEAM team = db.TEAM.Find(id);
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
            TEAM team = db.TEAM.Find(id);
            db.TEAM.Remove(team);
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