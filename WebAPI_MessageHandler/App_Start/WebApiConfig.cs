using System.Web.Http;
using WebAPI_MessageHandler.MessageHandlers;

namespace WebAPI_MessageHandler
{
    public static class WebApiConfig
    {
        // MessageHandlers in Web API

        // 1. HttpServer --> Gets the request from the host
        // 2. HttpRoutingDispatcher --> Dispathes the request based on the routing
        // 3. HttpControllerDispatcher --> Dispatches the request to WEB API controller



        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/Home",
                defaults: new { controller = "Home" }
            );

            config.Routes.MapHttpRoute(
               name: "DefaultApiWithMessageHandler",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional },
               constraints: null,
               handler: new NotFoundMessageHandler()
           // --> HttpServer --> CustomHeaderMessageHandler --> HttpRoutingDispather --> NotFoundMessageHandler(STOPPING HERE.. No call made to controller Dispather)
           );


            config.MessageHandlers.Add(new CustomHeaderMessageHandler());       // Globally
        }
    }
}
