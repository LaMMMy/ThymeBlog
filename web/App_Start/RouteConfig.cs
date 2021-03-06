﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Thyme.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("BlogPost", "blog/{slug}", new { controller="Blog", action="ViewPost" , slug=""});
            routes.MapRoute("ForceRepoRefresh", "ForceRepoRefresh", new { controller = "Blog", action = "ForceRepoRefresh" });
            routes.MapRoute("Front", "", new { controller = "Blog", action = "Index" });
            routes.MapRoute("About", "about", new { controller = "Home", action = "About" });
             
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
