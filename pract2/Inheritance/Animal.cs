namespace pract2.Inheritance
{
    public class Animal
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }

        public void ShowAnimal()
        {
            Console.WriteLine($"Animal name: {Name}");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{Name} says bow bow!");
        }
    }

    public class Puppy : Dog
    {
        public Puppy() : base("Puppy") { }

        public void Weep()
        {
            Console.WriteLine($"{Name} is weeping.");
        }
    }
}
