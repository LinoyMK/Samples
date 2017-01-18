using System;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            // AsyncException ex = new AsyncException();
            // ex.Check();

            AsyncTaskCancellation taskCancellation = new AsyncTaskCancellation();
            taskCancellation.Invoke();

            Console.ReadKey();
        }
    }
}
