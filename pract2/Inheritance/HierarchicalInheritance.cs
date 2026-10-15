namespace pract2.Inheritance
{
    public class NumberOperations
    {
        protected readonly int first;
        protected readonly int second;

        public NumberOperations(int a = 10, int b = 20)
        {
            first = a;
            second = b;
        }
    }

    public class Average : NumberOperations
    {
        public void DisplayOperation()
        {
            Console.WriteLine($"Average of {first} and {second}: {(first + second) / 2.0}");
        }
    }

    public class Maximum : NumberOperations
    {
        public void DisplayOperation()
        {
            Console.WriteLine($"Maximum of {first} and {second}: {Math.Max(first, second)}");
        }
    }
}
