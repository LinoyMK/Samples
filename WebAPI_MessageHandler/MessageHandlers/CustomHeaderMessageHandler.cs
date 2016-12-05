using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI_MessageHandler.MessageHandlers
{
    public class CustomHeaderMessageHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            response.Headers.Add("project", "WebAPI_MessageHandler");

            return response;
        }
    }
}