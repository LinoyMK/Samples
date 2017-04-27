using System;

namespace ConcurrentCollection.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            new BlockingCollectionTester().Test();
            Console.ReadKey();
        }
    }
}
