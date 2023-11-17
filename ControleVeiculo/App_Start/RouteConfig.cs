using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleVeiculo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Veiculos", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Search",
                url: "Veiculos/Search/{searchString}",
                defaults: new { controller = "Veiculos", action = "Search", searchString = UrlParameter.Optional }
            );
        }
    }
}
