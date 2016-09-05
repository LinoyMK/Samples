using System;

namespace TaskAwaitAndWait
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.RequestFood();
            System.Console.WriteLine("----------------");

            hotel.RequestFoodTaskResult();
            System.Console.WriteLine("----------------");

            hotel.RequestFoodAsync();
            System.Console.WriteLine("----------------");

            Console.ReadKey();
        }
    }
}
