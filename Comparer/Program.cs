using Comparer.EqualityComparer;
using Comparer.Test;
using System;

namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {

            new ComparerTest().Test();

            new EqualityComparerTest().Test();


            Console.ReadKey();
        }
    }
}
