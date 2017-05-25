using System;

namespace BridgePattern.Manuscript
{
    public class Book : ManuscriptBase
    {
        public Book(ICustomFormatter formatter) : base(formatter)
        {
        }

        public string Name { get; set; }
        public string AuthorName { get; set; }


        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Name", Name));
            Console.WriteLine(_formatter.Format("AuthorName", AuthorName));

        }

    }
}
