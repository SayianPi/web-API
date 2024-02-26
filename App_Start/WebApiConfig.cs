using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Routing;

namespace MyWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();    // Enable attribute routing: if we remove this line then attribute
                                                // routing of student controller won't work

            //Add default route using convention-based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //// define route
            //IHttpRoute defaultRoute = config.Routes.CreateRoute("api/{controller}/{id}",
            //                                    new { id = RouteParameter.Optional }, null);

            //// Add route
            //config.Routes.Add("DefaultApi", defaultRoute);




            // school route
            // we can configure multiple routes in the Web API using HttpConfiguration object.
            //convention-based routing for StudentController but there is also Attribute routing on the StudentController
            //(no need of this route configuration actually)
            config.Routes.MapHttpRoute(
                name: "student",
                routeTemplate: "api/student/{id}", //url for conventional based routing
                defaults: new { controller = "student", id = RouteParameter.Optional },
    
                constraints: new { id = "/d+" }
            );


            

            // configure json formatter
            JsonMediaTypeFormatter jsonFormatter = config.Formatters.JsonFormatter;

            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

        }
    }
}
