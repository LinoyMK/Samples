using System;

namespace GenericDelegates
{
    public class Predicate
    {
        public void Print()
        {
            Predicate<string> isLenghtGreaterThan5 = input => input.Length > 5;

            System.Console.WriteLine("Predicate : " + isLenghtGreaterThan5("Linoy.M.Kunjappan"));
        }
    }
}
