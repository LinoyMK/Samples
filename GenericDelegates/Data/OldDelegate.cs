namespace GenericDelegates
{
    public class OldDelegate
    {
        public delegate double AreaDelegate(int radius);
        private AreaDelegate area = CalculateArea;

        public void Print()
        {
            double result = area(10);
            System.Console.WriteLine("OldDelegate : " + result);
        }

        private static double CalculateArea(int radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
