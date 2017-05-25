using BridgePattern.Formatter;
using BridgePattern.Manuscript;
using System.Collections.Generic;

namespace BridgePattern
{
    // Putting Abstraction over abstraction
    class Program
    {
        static void Main(string[] args)
        {
            IList<ManuscriptBase> manuscripts = new List<ManuscriptBase>();

            // ICustomFormatter formatter = new ReverseFormatter();
            ICustomFormatter formatter = new StandardFormatter();


            ManuscriptBase book = new Book(formatter) { Name = "Book1", AuthorName = "Linoy" };
            ManuscriptBase faq = new FAQ(formatter) { Question1 = "My question" };

            manuscripts.Add(book);
            manuscripts.Add(faq);

            foreach (var item in manuscripts)
            {
                item.Print();
            }

            System.Console.ReadKey();

            // Here Manuscripts and Formatter can be extented..

        }
    }
}
