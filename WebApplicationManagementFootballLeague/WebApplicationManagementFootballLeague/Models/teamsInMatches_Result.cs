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
    
    public partial class teamsInMatches_Result
    {
        public Nullable<int> round { get; set; }
        public int ID_match { get; set; }
        public string dateOfMatch { get; set; }
        public string name { get; set; }
        public Nullable<int> hostScore { get; set; }
        public Nullable<int> guestScore { get; set; }
        public int ID_team { get; set; }
        public Nullable<bool> isHost { get; set; }
    }
}
