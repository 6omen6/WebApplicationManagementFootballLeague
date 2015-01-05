using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using WebApplicationManagementFootballLeague.Models;

namespace WebApplicationManagementFootballLeague
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //   clientId: "962578117004-5erhp7q22q3o90b0erk2heklaj12np4t.apps.googleusercontent.com",
            //    clientSecret: "hQOdB4QWp6TqG8T2uvmahjjM");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");
        }
    }
}
