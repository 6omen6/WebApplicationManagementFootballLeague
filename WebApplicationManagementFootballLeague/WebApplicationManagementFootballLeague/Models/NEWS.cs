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
    using System.Collections.Generic;
    
    public partial class NEWS
    {
        public NEWS()
        {
            this.COMMENTS = new HashSet<COMMENTS>();
        }
    
        public int ID_news { get; set; }
        public string date { get; set; }
        public string text { get; set; }
        public int ID_user { get; set; }
        public int ID_team { get; set; }
        public string title { get; set; }
        public Nullable<bool> isLeagueNews { get; set; }
        public int numberOfComments { get; set; }
    
        public virtual ICollection<COMMENTS> COMMENTS { get; set; }
        public virtual TEAM TEAM { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
