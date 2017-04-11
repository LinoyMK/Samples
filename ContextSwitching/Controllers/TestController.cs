using System.Web.Mvc;

namespace ContextSwitching.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ContentResult Index()
        {
            return Content("test");
        }
    }
}