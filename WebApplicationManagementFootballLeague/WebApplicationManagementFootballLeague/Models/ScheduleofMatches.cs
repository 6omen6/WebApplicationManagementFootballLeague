using System;
namespace WebApplicationManagementFootballLeague.Models
{
    public class Host
    {
        public int ID_host { get; set; }
        public string nameHost { get; set; }

    }
    public class Guest
    {
        public int ID_guest { get; set; }
        public string nameGuest { get; set; }
    }

    public class ScheduleofMatches
    {
        public int ID_match { get; set; }
        public int ID_host { get; set; }
        public int ID_guest { get; set; }
        public string nameHost { get; set; }
        public string nameGuest { get; set; }
        public int durationOfMatch { get; set; }
        public string dateOfMatch { get; set; }
        public int numberOfPlayers { get; set; }
        public Nullable<int> round { get; set; }
        public Nullable<int> hostScore { get; set; }
        public Nullable<int> guestScore { get; set; }
        public string timeOfMatch { get; set; }
    }
}
