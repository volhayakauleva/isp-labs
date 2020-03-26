using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Person
    {
        protected static int personCounter;
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            personCounter++;
        }

        public static void peopleAmount()
        {
            Console.WriteLine("\nОбщее количество людей: " + personCounter);
        }

        public void Show()
        {
            Console.WriteLine("Имя: " + Name);
        }
    }

    class Student : Person
    {
        protected string University { get; set; }

        public Student(string name, string university) : base(name)
        {
            University = university;
        }
        public new void Show()
        {
            Console.WriteLine("Имя: " + Name + "\nУниверситет: " + University);
        }
    }

    class StudentWithSpecialty : Student
    {
        protected string Specialty { get; set; }

        public StudentWithSpecialty(string name, string university, string specialty) : base(name, university)
        {
            Specialty = specialty;
        }
        public new void Show()
        {
            Console.WriteLine("Имя: " + Name + "\nУниверситет: " + University + "\nСпециальность: " + Specialty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            StudentWithSpecialty prog = new StudentWithSpecialty("Ваня", "БГУИР", "Программист");
            StudentWithSpecialty math = new StudentWithSpecialty("Маша", "БГУИР", "Математик");
            StudentWithSpecialty paint = new StudentWithSpecialty("Петя", "БГУ", "Художник");

            prog.Show();
            Person.peopleAmount();

            Console.ReadKey();
        }
    }
}

