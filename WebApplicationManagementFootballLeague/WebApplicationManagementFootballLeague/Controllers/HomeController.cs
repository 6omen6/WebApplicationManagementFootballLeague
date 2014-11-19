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
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            if (System.Web.HttpContext.Current.Session["BodyPage"] != null)
            {
                ViewData["BodyPage"] = System.Web.HttpContext.Current.Session["BodyPage"];
            }
            else
            {
                ViewData["BodyPage"] = "News";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            System.Web.HttpContext.Current.Session["BodyPage"] = "News";
            return PartialView("~/Views/Partial/_NewsPartial.cshtml");
        }
        public ActionResult FootballTeam()
        {
            System.Web.HttpContext.Current.Session["BodyPage"] = "FootballTeam";
            return PartialView("~/Views/Partial/_FootballTeamPartial.cshtml");
        }


    }
}
