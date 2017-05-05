using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace HttpWebClientPerformance.RestSharpTester
{
    public class RestSharpTester
    {
        public async Task<string[]> TestMultipleCall()
        {
            Task<string> t1 = MakeCall("https://www.google.co.in/?gfe_rd=cr&ei=eSEIWazSGuOK8QfQ-JSQAw&gws_rd=ssl#q=test1");
            Task<string> t2 = MakeCall("http://home.frontiersin.org/");
            Task<string> t3 = MakeCall("http://journal.frontiersin.org/journal/applied-mathematics-and-statistics/section/formal-methods");
            Task<string> t4 = MakeCall("http://journal.frontiersin.org/journal/immunology/section/alloimmunity-and-transplantation");
            Task<string> t5 = MakeCall("http://journal.frontiersin.org/researchtopic/1563/augmentation-of-brain-function-facts-fiction-and-controversy");
            Task<string> t6 = MakeCall("http://journal.frontiersin.org/researchtopic/364/the-microbial-ferrous-wheel-iron-cycling-in-terrestrial-freshwater-and-marine-environments");
            Task<string> t7 = MakeCall("http://journal.frontiersin.org/researchtopic/134/neural-effects-of-mindfulnesscontemplative-training");
            Task<string> t8 = MakeCall("http://journal.frontiersin.org/researchtopic/104/brain-and-art");

            var result = await Task.WhenAll(t1, t2, t3, t4, t5, t6, t7, t8);
            return result;
        }

        public Task<string> MakeCall(string url)
        {
            var task = new TaskCompletionSource<string>();
            // ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(IgnoreCertificateErrorHandler);
            ServicePointManager.DefaultConnectionLimit = 10;// Default is 2
            var client = new RestClient(url);
            client.Proxy = null;
            var request = new RestRequest();
            var result = client.ExecuteAsync(request, response => task.SetResult(response.Content));
            return task.Task;
        }
    }
}
