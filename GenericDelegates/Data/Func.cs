using System;

namespace GenericDelegates
{
    public class Func
    {
        public void Print()
        {
            Func<int, double> area = radius => 3.14 * radius * radius;

            double result = area(10);
            System.Console.WriteLine("Func : " + result);
        }
    }
}
