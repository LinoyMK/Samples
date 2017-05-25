using System;
using System.Linq;

namespace BridgePattern.Formatter
{
    public class ReverseFormatter : Manuscript.ICustomFormatter
    {
        public string Format(string key, string value)
        {
            return $"Key : {key}, value: {Reverse(value)}";
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
