using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee();
            employees[1] = new Employee();
            Console.WriteLine(employees[0] + "\n");
            Console.WriteLine(employees[1] + "\n");
            

            Plane[] planes = new Plane[2];
            planes[0] = new Plane();
            planes[1] = new Plane();
            Console.WriteLine(planes[0] + "\n");
            Console.WriteLine(planes[1] + "\n");
          

            Matrix a = new Matrix();
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
