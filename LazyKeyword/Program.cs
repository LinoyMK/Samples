using System;
using System.Threading;

namespace LazyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<string> executionAndPublication = new Lazy<string>(() => GetException(), LazyThreadSafetyMode.ExecutionAndPublication); //--> Exception also cached..
            bool isValueCreated = executionAndPublication.IsValueCreated;
            var data = executionAndPublication.Value;
            var data2 = executionAndPublication.Value;


            Lazy<string> publication = new Lazy<string>(() => GetException(), LazyThreadSafetyMode.PublicationOnly); // --> Exceptions are not cached..
            bool isValueCreated1 = publication.IsValueCreated;
            var data3 = publication.Value;
            var data4 = publication.Value;


        }

        private static string GetException()
        {
            throw new NotImplementedException("Tesiting exception caching");
        }
    }
}
