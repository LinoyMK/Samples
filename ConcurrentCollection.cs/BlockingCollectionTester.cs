using System.Collections.Concurrent;

namespace ConcurrentCollection.cs
{
    public class BlockingCollectionTester
    {
        public void Test()
        {
            BlockingCollection<int> blockingColl = new BlockingCollection<int>(2);

            for (int i = 0; i < 5; i++)
            {
                blockingColl.Add(i);
            }


        }

    }
}
