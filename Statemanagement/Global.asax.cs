using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Statemanagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["hitCounter"] = 0; // Read from file

        }
        protected void Application_End()
        {
            //Save hitcounter to file
        }
        protected void Session_Start()
        {
            Application.Lock();
            Application["hitCounter"] = (int)Application["hitCounter"] + 1;
            Application.UnLock();
        }
        protected void Session_End()
        {
        }
    }
}
