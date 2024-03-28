namespace MyTaskNow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student nezrin = new Student ( "Nezrin", "Eliyeva", "AB106", 80 );
            Student nigar = new Student ( "Nigar", "Alizade", "AB106", 87 );
            Student cavid = new Student ( "Cavid", "Ceferli", "AB106", 59 );
            Student xelil = new Student ( "Xelil", "Akifli", "AB106", 99 );

            Student[] std = { nezrin, nigar, cavid, xelil };

            foreach (Student student in std)
            {
                student.Getİnfo();
                student.CheckGraduation();
                student.GetDiplomDegree();
            }
}
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduate;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduate = CalcIsGrated();
        }
        public void Getİnfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, {(isGraduate ? "" : "")}");
        }
        public bool CalcIsGrated()
        {
            return Point >= 65;
        } 


        public void CheckGraduation()
        {
            if (isGraduate)
            {
                Console.WriteLine($"{Name} mezun olub.");
            }
            else
            {
                Console.WriteLine($"{Name} mezun olmayib");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Yoxdur");
            }
            else if(Point>=65 && Point <=80)
            {
                Console.WriteLine("Adi");
            }
            else if(Point>80 && Point <= 90)
            {
                Console.WriteLine("Seref");
            }
            else 
            {
                Console.WriteLine("Yuksek seref");
            }
        }

    }

}
