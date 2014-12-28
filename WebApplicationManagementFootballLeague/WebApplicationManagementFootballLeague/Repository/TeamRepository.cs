using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationManagementFootballLeague.Models;

namespace WebApplicationManagementFootballLeague.Repository
{
    public class TeamRepository : Controller
    {
        private BaseSZLPEntities db = new BaseSZLPEntities();


        /// <summary>
        ///     Wyciaga z bazy informacje na temat danej roli w danym klubie 
        ///     przyjmuje parametr 1 ID i 2 daną role np. 'Trener'
        /// </summary>
        public List<PLAYER> GetPlayersByID(int id_team)
        {
            List<PLAYER> listOfPlayersByID = new List<PLAYER>();
            var result = db.listOfPlayersInTeam(id_team).ToList();
            foreach (var element in result)
            {
                var tmp = new PLAYER();
                tmp.firstName = element.firstName;
                tmp.lastName = element.lastName;
                tmp.isActivePlayer = element.isActivePlayer;
                tmp.number = element.number;
                tmp.numberOfAssists = element.numberOfAssists;
                tmp.numberOfGoals = element.numberOfGoals;
                tmp.numberOfRedCards = element.numberOfRedCards;
                tmp.numberOfYellowCards = element.numberOfYellowCards;
                tmp.picture = element.position;
                tmp.position = element.position;
                tmp.timeOnThePitch = element.timeOnThePitch;
                listOfPlayersByID.Add(tmp);
            }
            return listOfPlayersByID;
        }

        /// <summary>
        ///     Wyciaga z bazy informacje na temat danej roli w danym klubie 
        ///     przyjmuje parametr 1 ID i 2 daną role np. 'Trener'
        /// </summary>
        public List<STAFF> StaffInTeamByRole(int id_team, string role)
        {
            List<STAFF> listOfStaffByRole = new List<STAFF>();
            var result = db.staffInTeamByRole(id_team, role).ToList();
            foreach (var element in result)
            {
                var tmp = new STAFF();
                tmp.firstName = element.firstName;
                tmp.lastName = element.lastName;
                listOfStaffByRole.Add(tmp);
            }
            return listOfStaffByRole;
        }
        /// <summary>
        ///     Wyciaga z bazy News'y dla danej drużyny
        /// </summary>
        public List<NEWS> ListOfNews(int id_team)
        {
            List<NEWS> listOfNews = new List<NEWS>();
            var result = db.newsForTheTeam(id_team).ToList();
            foreach (var element in result)
            {
                var tmp = new NEWS();
                tmp.title = element.title;
                tmp.text = element.text;
                tmp.date = element.date;
                listOfNews.Add(tmp);
            }
            return listOfNews;
        }
    }
}
