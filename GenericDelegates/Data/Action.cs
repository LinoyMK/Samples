using System;

namespace GenericDelegates
{
    public class Action
    {
        public void Print()
        {
            Action<int> myAction = input => Console.WriteLine("Action: Return type is void" + input);

            myAction(10);
        }
    }
}
