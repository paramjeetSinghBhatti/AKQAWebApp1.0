using AKQACodingTestApp.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace AKQAWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            //ExceptionHandler is inheriting from IExceptionHandler interface and Web API has already this type of class registered
            /// so we just need to replace this class to our custom exception handler class because Web API doesn’t support multiple ExceptionHandler.
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler()); 

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
