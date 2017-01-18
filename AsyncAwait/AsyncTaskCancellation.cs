using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncTaskCancellation
    {
        public async void Invoke()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            Task<string> taskData = InvokeTaskToCancel(tokenSource.Token);
            tokenSource.Cancel(); // Cancelling the token

            string data = null;
            try
            {
                data = await taskData; // will Fail, Bcoz here the token will be cancelled before 1000ms.
            }
            catch (OperationCanceledException ex)
            {
                System.Console.WriteLine(ex);
            }

            System.Console.WriteLine(data);
        }


        public async Task<string> InvokeTaskToCancel(CancellationToken token)
        {
            Console.WriteLine("IsCancellation requested before delay: " + token.IsCancellationRequested);

            await Task.Delay(1000); // Task to make a delay of 1000ms so the execution returns back.

            Console.WriteLine("IsCancellation requested after delay: " + token.IsCancellationRequested);

            token.ThrowIfCancellationRequested(); // Checks whether the current token is cancelled at this moment.
            return await Task.FromResult("hello!!");
        }
    }


}
