using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoMVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom Routes
            //MVC framework evaluates each route in sequence. It starts with first configured route and if incoming 
            //url doesn't satisfy the URL pattern of the route then it will evaluate second route and so on.
            
            routes.MapRoute(
                name: "Dashboard",
                url: "dashboard",
                defaults: new { controller = "MyHome", action = "Index" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
