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
    
    public partial class STAFF_IN_MATCHES
    {
        public int ID_staff { get; set; }
        public int ID_match { get; set; }
        public string role { get; set; }
    
        public virtual MATCH MATCH { get; set; }
        public virtual STAFF STAFF { get; set; }
    }
}
