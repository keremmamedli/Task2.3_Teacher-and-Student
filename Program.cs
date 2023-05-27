namespace Code_Academy_Task2._3__Teacher_Student_
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string Name , string Surname , int Age)
        {
            this.Name = Name;

            this.Surname = Surname;

            this.Age = Age;
        }
    }

    class Teacher : Person
    {
        public Teacher(string  Name , string Surname , int Age) : base(Name , Surname , Age) { }

        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
    }


    class Student : Person
    {
        public Student(string Name , string Surname , int Age) : base (Name , Surname , Age) { }

        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher("Niyazi", "Babayev" , 21);

            var student = new Student("Karam", "Mammadli", 18);
            Console.WriteLine(teacher.Name + " " +  teacher.Surname);
            
            teacher.Explain();
            
            
            
            Console.WriteLine(student.Name + " " + student.Surname);
            
            student.Learn();
        }
    }
}