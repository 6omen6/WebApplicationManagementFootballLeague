using Microsoft.Web.WebPages.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationManagementFootballLeague.App_Start
{
    public class OAuthConfig
    {
        public static void RegisterProviders()
        {
            OAuthWebSecurity.RegisterGoogleClient();
            OAuthWebSecurity.RegisterFacebookClient(
                appId: "834877566554270",
                appSecret: "7192831fc3a6a4769f671902defc28ee",
                displayName:"facebook"
                );
        }
    }
}
