//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationManagementFootballLeague.Models
{
    using System;
    
    public partial class listOfMatchesWithTeamNamesAndScores_Result
    {
        public int ID_match { get; set; }
        public string timeOfMatch { get; set; }
        public string dateOfMatch { get; set; }
        public Nullable<int> round { get; set; }
        public int durationOfMatch { get; set; }
        public int numberOfPlayers { get; set; }
        public string name { get; set; }
        public Nullable<int> hostScore { get; set; }
        public Nullable<int> guestScore { get; set; }
        public string guestName { get; set; }
    }
}
