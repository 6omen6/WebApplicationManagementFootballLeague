using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.Models
{
    public class FacebookLoginModel
    {
        public string uid { get; set; }
        public string accessToken { get; set; }
    }
}
