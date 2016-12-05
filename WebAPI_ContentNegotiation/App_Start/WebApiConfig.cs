using System.Web.Http;

namespace WebAPI_ContentNegotiation
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            HandleApiContentNegotiation(config);
        }

        public static void HandleApiContentNegotiation(HttpConfiguration config)
        {
            // When request comes in based on the request accept header,
            //web api finds suitable mediatype formatters classes(Predefined => json/xml)
            // to serialize the response, this process is called content negotiation. 


            config.Formatters.Remove(config.Formatters.XmlFormatter); // Removes the Xml formatter so always json


        }

    }
}
