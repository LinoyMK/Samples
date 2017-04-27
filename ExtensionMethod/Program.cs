using ExtensionMethod.ExceptionExtensions;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTester exTester = new ExceptionTester();
            exTester.Test();

            Console.ReadKey();

        }
    }
}
