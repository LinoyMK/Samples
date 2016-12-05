using StructVsClass.RealTime;
using System;

namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            new RealTimeHandler().Check();

            Console.ReadKey();
        }
    }
}
