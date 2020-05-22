using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Loop.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

           // config.Routes.MapHttpRoute(
           //    name: "robtest2Api",
           //    routeTemplate: "api/{controller}/{action}/{price}",
           //    defaults: new { price = RouteParameter.Optional }
           //);

        }
    }
}
