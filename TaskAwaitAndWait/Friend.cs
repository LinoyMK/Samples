using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAwaitAndWait
{
    public class Friend
    {
        public async Task<bool> TalkAsync()
        {
            Console.WriteLine("Friend started talking to me async...");
            bool isTalk = await Task.Run(() => Talk());
            return isTalk;
        }

        public bool Talk()
        {
            Console.WriteLine("Friend started talking to me sync...");
            bool isTalk = true;
            Thread.Sleep(5000);
            return isTalk;
        }
    }
}
