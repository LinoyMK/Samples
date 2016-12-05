using System;
using System.Threading;
using System.Threading.Tasks;

namespace EventAsExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStringAsync(123)
                .Done(m => InvokeTestFunc(m))
                .Fail(() => Console.WriteLine("Some thing failed in my async function..."))
                .End();

            Console.WriteLine("After the method invoke...");
            Console.ReadKey();
        }

        private static void InvokeTestFunc(object m)
        {
            Console.WriteLine("Hello" + (string)m);
        }

        private static Task<string> GetStringAsync(int id)
        {
            Task<string> name = Task.Run(() =>
            {
                Thread.Sleep(10000);
                // return "Linoy.M.Kunjappan";
                throw new Exception("testing");
                return "dfd";
            });
            return name;
        }
    }

    public static class ClassA
    {
        private delegate void OnDone<T>(T response, Action<T> action);
        private delegate void OnFail(Action action);

        private static event OnDone<object> success;
        private static event OnFail fail;

        private static Action failedAction { get; set; }
        private static Action<object> successAction { get; set; }


        public static Task<T> Done<T>(this Task<T> obj, Action<object> action = null)
        {
            success += AfterSuccess;
            successAction = action;//--> Action<object>, need to check the interface compatibility...
            return obj;
        }

        public static Task<T> Fail<T>(this Task<T> obj, Action action = null)
        {
            fail += AfterFail;
            failedAction = action;
            return obj;
        }

        private static void AfterSuccess<T>(T response, Action<T> action = null)
        {
            action?.Invoke(response);
            Console.WriteLine("After Success!!" + response);
        }

        private static void AfterFail(Action action = null)
        {
            action?.Invoke();
            Console.WriteLine("After Fail !!");
        }

        public static async void End<T>(this Task<T> obj)
        {
            try
            {
                T response = await obj;
                if (obj.IsCompleted)
                {
                    success?.Invoke(response, successAction);
                }
            }
            catch (Exception ex)
            {
                fail?.Invoke(failedAction); //--> Need to pass the error message.
            }

        }
    }
}
