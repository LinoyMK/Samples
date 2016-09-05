using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAwaitAndWait
{
    public class Me
    {
        public bool Talk()
        {
            Console.WriteLine("Me started talking sync...");
            bool isTalk = true;
            Thread.Sleep(5000);
            return isTalk;
        }

        public async Task<bool> TalkAsync()
        {
            Console.WriteLine("Me started talking async...");
            bool isTalk = await Task.Run(() => Talk());
            return isTalk;
        }

        public bool Order()
        {
            Console.WriteLine("Me ordered sync...");
            bool isOrder = true;
            Thread.Sleep(5000);

            return isOrder;
        }

        public async Task<bool> OrderAsync()
        {
            Console.WriteLine("Me ordered async");
            bool isOrder = await Task.Run(() => Order());

            return isOrder;
        }
    }
}
