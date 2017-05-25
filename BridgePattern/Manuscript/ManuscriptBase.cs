namespace BridgePattern.Manuscript
{
    public abstract class ManuscriptBase
    {
        protected readonly ICustomFormatter _formatter;

        public ManuscriptBase(ICustomFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Print();
    }
}
