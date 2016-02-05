using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Student
    {
        public string name;
        public string surname;
        public string ID;
        public double GPA;
        public void printFullName()

        {
            Console.WriteLine(this.name + " " + this.surname + " " + this.ID + " " + this.GPA);

        }
        public override string ToString()
        {
            return this.name + " " + surname + " " + ID + " " + GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.name = "Nurly";
            a.surname = "Baimnuratova";
            a.ID = "15BD02097";
            a.GPA = 4.0;
            a.printFullName();
            Console.ReadKey();
        }
    }
}
