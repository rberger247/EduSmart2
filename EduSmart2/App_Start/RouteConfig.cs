﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EduSmart2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                //url: "Home/{ *.}",   
        url: "{controller}/{action}/{id}",
         // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         defaults: new { controller = "Home", action = "Main", id = UrlParameter.Optional }

        );
        }
    }
}
