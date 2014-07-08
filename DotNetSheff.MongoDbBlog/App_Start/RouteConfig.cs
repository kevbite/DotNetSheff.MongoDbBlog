using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetSheff.MongoDbBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "PostsByTag",
                url: "tag/{tag}",
                defaults: new { controller = "Blog", action = "PostsByTag" }
            );

            routes.MapRoute(
                name: "Slug",
                url: "{year}/{month}/{slug}",
                defaults: new { controller = "Blog", action = "Post" },
                constraints: new { year = @"\d{4}", month = @"\d{1,2}" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "Posts", id = UrlParameter.Optional }
            );

        }
    }
}