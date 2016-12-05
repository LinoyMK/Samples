using System;

namespace PreAndPostIncrement
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine(i++);
            Console.WriteLine(++i);

            // Ans : 5 & 7

            Console.ReadKey();


        }
    }
}
