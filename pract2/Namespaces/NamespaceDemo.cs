using PATA = pract2.Namespaces.ProjectA.TeamA.ClassA;

namespace pract2.Namespaces
{
    public static class NamespaceDemo
    {
        public static void Run()
        {
            Console.WriteLine("Hello from the main program!");
            PATA.Print();
        }
    }

    namespace ProjectA.TeamA
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello from ClassA using a namespace alias.");
            }
        }
    }
}
