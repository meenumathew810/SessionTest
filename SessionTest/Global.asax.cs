using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace SessionTest
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Lock();
            Application["test"] = "my new data";
            Application.UnLock();
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["test"] = "~/About.aspx";
        }
    

    }
}