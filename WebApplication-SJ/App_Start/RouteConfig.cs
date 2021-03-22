using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication_SJ
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Student_info",
                 url: "{Home}/{Student_info}/{id}",
                 defaults: new {controller ="Home", action =  "Student_info"}
                );

            routes.MapRoute(
                 name: "About",
                 url: "{Home}/{About}/{id}",
                 defaults: new { controller = "Home", action = "About" }
                 );
              
            routes.MapRoute(
                 name: "Contact",
                 url: "{Home}/{Contact}/{id}",
                 defaults: new { controller = "Home", action = "Contact" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
