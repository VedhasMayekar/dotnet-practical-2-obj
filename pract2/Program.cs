using pract2.Classes;
using pract2.Inheritance;
using pract2.Overloading;
using pract2.Namespaces;

namespace pract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRACTICAL 2 - OBJECT ORIENTED PROGRAMMING");
            Console.WriteLine("1. Classes and Objects");
            Console.WriteLine("2. Function Overloading");
            Console.WriteLine("3. Constructor Overloading");
            Console.WriteLine("4. Single Inheritance");
            Console.WriteLine("5. Hierarchical Inheritance");
            Console.WriteLine("6. Multilevel Inheritance");
            Console.WriteLine("7. Multiple Inheritance using Interfaces");
            Console.WriteLine("8. Namespace and Alias");

            Console.Write("\nEnter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            switch (choice)
            {
                case 1:
                    var student = new Student(97, "Vedhas", "B.Sc Computer Science");
                    student.Display();
                    break;
                case 2:
                    var functions = new FunctionOverloading();
                    functions.Add(20, 30);
                    functions.Add(20, 30, 40);
                    functions.Add(12.5, 7.5);
                    functions.Add(1.2, 2.3, 3.4);
                    break;
                case 3:
                    new StudentRecord().Run();
                    break;
                case 4:
                    var dog = new Dog("Bruno");
                    dog.ShowAnimal();
                    dog.Bark();
                    break;
                case 5:
                    var average = new Average();
                    average.DisplayOperation();
                    var maximum = new Maximum();
                    maximum.DisplayOperation();
                    break;
                case 6:
                    var puppy = new Puppy();
                    puppy.Eat();
                    puppy.Bark();
                    puppy.Weep();
                    break;
                case 7:
                    Shape circle = new Circle(5);
                    circle.Draw();
                    ((IMeasurements)circle).ShowAreaAndPerimeter();
                    break;
                case 8:
                    NamespaceDemo.Run();
                    break;
                default:
                    Console.WriteLine("Please choose a number from 1 to 8.");
                    break;
            }
        }
    }
}
