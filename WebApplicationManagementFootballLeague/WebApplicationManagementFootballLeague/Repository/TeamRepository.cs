using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationManagementFootballLeague.Models;
using WebMatrix.WebData;

namespace WebApplicationManagementFootballLeague.Repository
{
    public class TeamRepository : Controller
    {
        private BaseSZLPEntities db = new BaseSZLPEntities();



        /// <summary>
        ///     Wyciaga z bazy informacje na temat danej roli w danym klubie 
        ///     przyjmuje parametr 1 ID i 2 daną role np. 'Trener'
        /// </summary>
        public UserProfile GetUserByID(int id)
        {
            var context = new UsersContext();
            var result = context.UserProfiles.SingleOrDefault(u => u.UserId == id);

            var tmp = new UserProfile();
            tmp.UserId = result.UserId;
            tmp.UserName = result.UserName;
            tmp.firstName = result.firstName;
            tmp.lastName = result.lastName;
            tmp.avatar = result.avatar;
            

            return tmp;
        }

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
                tmp.userName = element.UserName;
                tmp.numberOfComments = element.numberOfComments;
                listOfNews.Add(tmp);
            }
            return listOfNews;
        }
        public List<ScheduleofMatches> schleduleOfMatches()
        {
            var host = db.listOfMatchesOfHosts().ToList();
            var listOfHost = new List<Host>();
            foreach (var element in host)
            {
                var tmp = new Host();
                tmp.ID_host = element.ID_team;
                tmp.nameHost= element.name;
                listOfHost.Add(tmp);
            }
            var quest = db.listOfMatchesOfGuests().ToList();
            var listOfGuest = new List<Guest>();
            foreach (var element in quest)
            {
                var tmp = new Guest();
                tmp.ID_guest = element.ID_team;
                tmp.nameGuest = element.name;
                listOfGuest.Add(tmp);
            }
            List<MATCH> listOfMatches = new List<MATCH>();
            var resultt = db.leagueMatches().ToList();
            foreach (var element in resultt)
            {
                var tmp = new MATCH();
                tmp.dateOfMatch = element.dateOfMatch;
                tmp.round = element.round;
                tmp.guestScore = element.guestScore;
                tmp.hostScore = element.hostScore;
                listOfMatches.Add(tmp);
            }
            List<ScheduleofMatches> listScheduleofMatches = new List<ScheduleofMatches>();
            for (int i = 0; i < 66; i++)
            {
                var tmpa = new ScheduleofMatches();
                tmpa.nameHost = listOfHost[i].nameHost;
                tmpa.ID_host = listOfHost[i].ID_host;
                tmpa.nameGuest = listOfGuest[i].nameGuest;
                tmpa.ID_guest= listOfGuest[i].ID_guest;
                tmpa.round = listOfMatches[i*2].round;
                tmpa.dateOfMatch = listOfMatches[i * 2].dateOfMatch;
                tmpa.hostScore = listOfMatches[i * 2].hostScore;
                tmpa.guestScore = listOfMatches[i * 2].guestScore;
                listScheduleofMatches.Add(tmpa);
            }

            return listScheduleofMatches;
        }
    }
}
