using System.Threading.Tasks;
using System.Web.Mvc;

namespace ContextSwitching.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public async Task<ContentResult> Index()
        {
            var httpContext = System.Web.HttpContext.Current;
            await GetStringAsync().ConfigureAwait(false);

            var httpContextAfter = System.Web.HttpContext.Current;
            return Content("testing");
        }

        public async Task GetStringAsync()
        {
            await Task.Delay(1000);
            //return await Task.FromResult("data from async method");
        }
    }
}