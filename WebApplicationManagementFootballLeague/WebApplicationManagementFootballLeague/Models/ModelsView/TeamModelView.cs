using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.Models.ModelsView
{
    public class TeamModelView
    {
        public UserProfile profile { get; set; }
        public TEAM team { get; set; }
        public NEWS news { get; set; }
        public STAFF staff { get; set; }
        public int ID = 1;
        public int ID_team { get; set; }
        public ICollection<TEAM> listOfTeams { get; set; }
        public List<COMMENT> listOfComments { get; set; }
        public List<NEWS> listOfNews { get; set; }
        public List<STAFF> listOfPresidents { get; set; }
        public List<STAFF> listOfVPresidents { get; set; }
        public List<STAFF> listOfManagers { get; set; }
        public List<STAFF> listOfCoaches { get; set; }
        public List<PLAYER> listOfPlayers { get; set; }
        public List<ScheduleofMatches> listOfScheduleofMatches { get; set; }
        public MyMailModel objModelMail { get; set; }
        public int numbersOfNews { get; set; }
        public int idNews { get; set; }
        public int numberOfComments { get; set; }
        public int numberOfPlayers { get; set; }
        public COMMENT comment { get; set; }




        public IEnumerable<SelectListItem> selectedListOfTeams
        {
            get { return new SelectList(listOfTeams, "ID_Team", "name"); }
        }
    }
}