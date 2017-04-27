using System.Threading.Tasks;
using System.Web.Mvc;

namespace ContextSwitching.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public async Task<ContentResult> WithOutContextSwitch()
        {
            string message = string.Empty;
            var httpContext = System.Web.HttpContext.Current;
            await GetStringAsync().ConfigureAwait(continueOnCapturedContext: false); // Original request context is not captured

            var httpContextAfter = System.Web.HttpContext.Current;
            if (httpContextAfter == null)
            {
                message = "HttpContext is null after removing the context switching with ConfigureAwait(false)";
            }
            else
            {
                message = "HttpContext is not null";
            }
            return Content(message);
        }

        public async Task<ContentResult> WithContextSwitch()
        {
            string message = string.Empty;
            var httpContext = System.Web.HttpContext.Current;
            await GetStringAsync(); // Request context is captured by default.

            var httpContextAfter = System.Web.HttpContext.Current;
            if (httpContextAfter == null)
            {
                message = "HttpContext is null";
            }
            else
            {
                message = "HttpContext is not null";
            }
            return Content(message);
        }

        public async Task GetStringAsync()
        {
            await Task.Delay(1000);
            //return await Task.FromResult("data from async method");
        }
    }
}