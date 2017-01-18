using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncException
    {
        public async void Check()
        {
            try
            {
                // await GetFirstString();

                // GetFirstString().Wait();

                // await GetSecondString();
                await Task.WhenAll(GetFirstString(), GetSecondString()); // Always getting about the exception of first, Second exception is unobservable.
            }
            catch (System.Exception ex)
            {

            }
        }

        private Task<string> GetFirstString()
        {
            Thread.Sleep(50);
            throw new NotImplementedException("Exception from the first string");
            return Task.FromResult("First");
        }

        private Task<string> GetSecondString()
        {
            Thread.Sleep(100);

            throw new NotImplementedException("Exception from the second string");

            return Task.FromResult("Second");
        }
    }
}
