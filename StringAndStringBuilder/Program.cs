using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopString();

            System.Console.ReadKey();

            LoopStringBuilder();

            System.Console.ReadKey();
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
