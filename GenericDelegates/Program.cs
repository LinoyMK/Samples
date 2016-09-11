using System;

namespace GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            OldDelegate oldWay = new OldDelegate();
            oldWay.Print();

            Predicate predicate = new Predicate();
            predicate.Print();


            Action action = new Action();
            action.Print();

            Func func = new Func();
            func.Print();

            Console.ReadKey();

        }
    }
}
