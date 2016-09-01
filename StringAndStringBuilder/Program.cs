using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopString();

            // The heap size object count = 1130
            System.Console.ReadKey();

            LoopStringBuilder();

            System.Console.ReadKey();

            // The heap size object count = 1131 (1130 + 1) --> means only one object
        }

        public static void LoopString()
        {
            string data = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                data = data + i;
            }

            System.Console.WriteLine("Loop String completed..");
        }


        public static void LoopStringBuilder()
        {
            StringBuilder data = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                data.Append(i);
            }

            System.Console.WriteLine("LoopStringBuilder completed..");
        }
    }
}
