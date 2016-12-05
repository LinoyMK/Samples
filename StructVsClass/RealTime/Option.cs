namespace StructVsClass.RealTime
{
    public struct Option<T>  // Struct to handle the null
    {
        private readonly T _value;
        public Option(T value)
        {
            _value = value;
        }

        public bool HasValue => _value != null;

        public T Value => _value;
    }
}
