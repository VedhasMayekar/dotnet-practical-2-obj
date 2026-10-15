namespace pract2.Overloading
{
    public class FunctionOverloading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of two integers: {a + b}");
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Addition of three integers: {a + b + c}");
        }

        public void Add(double a, double b)
        {
            Console.WriteLine($"Addition of two decimal values: {a + b}");
        }

        public void Add(double a, double b, double c)
        {
            Console.WriteLine($"Addition of three decimal values: {a + b + c}");
        }
    }
}
