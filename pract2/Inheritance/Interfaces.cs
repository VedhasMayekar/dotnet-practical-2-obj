namespace pract2.Inheritance
{
    public interface Shape
    {
        void Draw();
    }

    public interface IMeasurements
    {
        void ShowAreaAndPerimeter();
    }

    public class Circle : Shape, IMeasurements
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }

        public void ShowAreaAndPerimeter()
        {
            Console.WriteLine($"Area: {Math.PI * radius * radius:F2}");
            Console.WriteLine($"Perimeter: {2 * Math.PI * radius:F2}");
        }
    }
}
