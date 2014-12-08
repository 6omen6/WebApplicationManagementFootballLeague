using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.Models.ModelsView
{
    public class TeamModelView
    {
        public TEAM team { get; set; }
        public int ID = 1;
        public ICollection<TEAM> listOfTeams { get; set; }
        public IEnumerable<SelectListItem> selectedListOfTeams
        {
            get { return new SelectList(listOfTeams, "ID_Team", "name"); }
        }
    }
}