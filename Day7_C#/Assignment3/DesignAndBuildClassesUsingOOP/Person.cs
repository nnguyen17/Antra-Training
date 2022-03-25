using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public abstract void Infor();
        public abstract void Behavior();
        public virtual decimal Salary(int s = 0)
        {
            return s * 12;
        }
    }
    public class Student : Person
    {
        public int SchoolYear { get; set; }
        public string Major { get; set; }

        public override void Infor()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter School Year: ");
            SchoolYear = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter Major: ");
            Major = Console.ReadLine();
        }
        public override void Behavior()
        {
            Console.WriteLine("Studying");
        }
    }

    public class Instructor : Person
    {
        public int YearsOfExp { get; set; }
        public string Department { get; set; }

        public override void Infor()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Years of Experience: ");
            YearsOfExp = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter Department: ");
            Department = Console.ReadLine();
        }
        public override void Behavior()
        {
            Console.WriteLine("Teaching");
        }
        public override decimal Salary(int s = 0)
        {
            return base.Salary(s) + YearsOfExp*10000;
        }
    }
}
