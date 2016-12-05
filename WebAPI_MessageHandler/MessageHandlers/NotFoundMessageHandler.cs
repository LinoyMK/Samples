using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI_MessageHandler
{
    public class NotFoundMessageHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // return await base.SendAsync(request, cancellationToken); --> (Here the propagation to default HttpRouteDispatcher
            //// and HttpControllerDispatcher handlers were prevented..)
            try
            {
                var result = await base.SendAsync(request, cancellationToken);
                return result;
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("The inner handler has not been assigned.")) // Error occuring if the controller is not found.
                {
                    var response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                    response.Content = new StringContent("{\"value\" : \"Wrong path\"}");
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
                else
                {
                    throw ex;
                }
            }


        }
    }
}