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
    
    public partial class EVENT
    {
        public int ID_event { get; set; }
        public string description { get; set; }
        public int minute { get; set; }
        public Nullable<int> ID_player { get; set; }
        public Nullable<int> ID_match { get; set; }
    
        public virtual MATCH MATCH { get; set; }
        public virtual PLAYER PLAYER { get; set; }
    }
}
