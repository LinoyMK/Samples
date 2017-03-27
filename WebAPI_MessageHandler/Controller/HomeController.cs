using System.Web.Http;

namespace WebAPI_MessageHandler.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Message from Home controller");
        }


    }


}
