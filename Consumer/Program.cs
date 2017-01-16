using Core;

// Both are constants , but constant value will add in compile time and readonly value will add at runtime.
// ReadOnly => we can initialize it from the constructor.
namespace Consumer
{
    // Steps
    // 1. Update the Core project class file(CoreData.cs)
    // 2. Build the Core project 
    // 3. Pick the Core.dll and update the Consumer project bin(NO NEED TO REBUILD)
    // 4. Run te Consumer.ex
    // 5. Now we can see, only readonly is updated, constant value is same as previous, because it stored in the IL(Compile time)

    class Program
    {
        static void Main(string[] args)
        {
            // when referencing a dll having constant value, at first build of the Consumer project its value will hardcoded to the IL,
            // After that, if we need to change the constant(Here Core.dll) we need to rebuld the project(Here Consumer)
            System.Console.WriteLine("constant value" + CoreData.CustID);

            // ReadOnly is a runtime constant, whose value is added at runtime, so no need to build the Consumer project 
            // instead update the bin folder with the changed Dll(Core.dll)
            System.Console.WriteLine("ReadOnly value" + CoreData.UserID);

            System.Console.ReadKey();
        }
    }
}
