using System;

namespace ExtensionMethod.ExceptionExtensions
{
    public class ExceptionTester
    {
        public void Test()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                if (ex.IsSeriousException())
                {
                    // Do job
                }
                else if (ex.MustBeReThrown())
                {
                    // Do job
                }
                else if (ex.MustBeReThrownImmediatly())
                {
                    // Do job
                }
            }
        }

    }
}
