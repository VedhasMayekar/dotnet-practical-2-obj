namespace pract2.Classes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public Student(int id, string name, string course)
        {
            Id = id;
            Name = name;
            Course = course;
        }

        public void Display()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Course: {Course}");
        }
    }
}
