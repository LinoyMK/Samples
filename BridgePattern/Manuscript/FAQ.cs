using System;

namespace BridgePattern.Manuscript
{
    public class FAQ : ManuscriptBase
    {
        public FAQ(ICustomFormatter formatter) : base(formatter)
        {
        }

        public string Question1 { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Question1", Question1));
        }
    }
}
