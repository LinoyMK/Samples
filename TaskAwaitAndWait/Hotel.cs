using System;
using System.Threading.Tasks;

namespace TaskAwaitAndWait
{
    public class Hotel
    {
        public void RequestFood()
        {
            bool isOrdered = new Me().Order();
            bool isFriendTalk = new Friend().Talk();
            bool meTalk = new Me().Talk();

            Console.WriteLine("Leaved hotel");
        }

        public void RequestFoodTaskResult()
        {
            bool isOrdered = new Me().OrderAsync().Result;
            bool isFriendTalk = new Friend().TalkAsync().Result;
            bool isMeTalk = new Me().TalkAsync().Result;

            Console.WriteLine("Leaved hotel");
        }

        public void RequestFoodAsync()
        {
            Task<bool> isOrdered = new Me().OrderAsync();
            Task<bool> isFriendTalk = new Friend().TalkAsync();
            Task<bool> isMeTalk = new Me().TalkAsync();

            Task.WhenAll(isOrdered, isFriendTalk, isMeTalk);
            Console.WriteLine("Leaved hotel");
        }
    }
}
