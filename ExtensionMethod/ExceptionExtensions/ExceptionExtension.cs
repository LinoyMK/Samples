using System;

namespace ExtensionMethod.ExceptionExtensions
{
    public static class ExceptionExtension
    {
        public static bool IsSeriousException(this Exception ex)
        {
            if (ex is NullReferenceException)
            {
                return true;
            }
            return false;
        }

        public static bool MustBeReThrown(this Exception ex)
        {
            if (ex is NotImplementedException)
            {
                return true;
            }
            return false;
        }

        public static bool MustBeReThrownImmediatly(this Exception ex)
        {
            if (ex is NotImplementedException)
            {
                return true;
            }
            return false;
        }
    }
}
