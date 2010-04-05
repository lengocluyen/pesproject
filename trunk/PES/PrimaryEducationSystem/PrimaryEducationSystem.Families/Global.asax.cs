using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PrimaryEducationSystem.Families
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//<<<<<<< .mine
//            //routes.MapRoute(
//            //    "Default",                                              // Route name
//            //    "{controller}/{action}/{id}",                           // URL with parameters
//            //    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
//            //);
//            routes.IgnoreRoute("{myWebForms}.svc/{*pathInfo}");
//            routes.MapRoute(
//                "Services", "Services/PESservices.svc"
//                );
//=======
            //routes.MapRoute(
            //    "Default",                                              // Route name
            //    "{controller}/{action}/{id}",                           // URL with parameters
            //    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            //);

            routes.IgnoreRoute("{resource}.svc/{*pathInfo}");

            //routes.MapRoute("service", "Services/PESServices.svc");

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}