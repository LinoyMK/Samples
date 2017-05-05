using System;

namespace HttpWebClientPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            new RestSharpTester.RestSharpTester().TestMultipleCall().Wait();
            Console.ReadKey();
        }
    }
}
