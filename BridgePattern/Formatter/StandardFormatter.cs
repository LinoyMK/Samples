namespace BridgePattern.Formatter
{
    public class StandardFormatter : Manuscript.ICustomFormatter
    {
        public string Format(string key, string value)
        {
            return $"key : {key}, value : {value}";
        }
    }
}
