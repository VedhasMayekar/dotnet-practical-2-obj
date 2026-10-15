namespace pract2.Overloading
{
    public class StudentRecord
    {
        private readonly string name;
        private readonly int age;
        private readonly string course;
        private readonly string constructorUsed;

        public StudentRecord()
        {
            name = "Unknown";
            age = 0;
            course = "Unknown";
            constructorUsed = "Default constructor";
        }

        public StudentRecord(string studentName)
        {
            name = studentName;
            age = 0;
            course = "Unknown";
            constructorUsed = "Constructor with name";
        }

        public StudentRecord(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
            course = "Unknown";
            constructorUsed = "Constructor with name and age";
        }

        public StudentRecord(string studentName, int studentAge, string studentCourse)
        {
            name = studentName;
            age = studentAge;
            course = studentCourse;
            constructorUsed = "Constructor with name, age and course";
        }

        public void Run()
        {
            Print(new StudentRecord());
            Print(new StudentRecord("Vedhas"));
            Print(new StudentRecord("Vedhas", 20));
            Print(new StudentRecord("Vedhas", 20, "B.Sc CS"));
        }

        private static void Print(StudentRecord record)
        {
            Console.WriteLine($"Name: {record.name}, Age: {record.age}, Course: {record.course}");
            Console.WriteLine($"Used: {record.constructorUsed}\n");
        }
    }
}
