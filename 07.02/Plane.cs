using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    internal class Plane
    {
        private static string Name { get; set; }
        private  static string Year { get; set; }
        private static string Type { get; set; }

        private static string Brand;

        public Plane() { }
        public Plane(string name, string year, string type)
        {
            Name = name;
            Year = year;
            Type = type;
        }

        static Plane()
        {
            Console.WriteLine("Введите идентификатор самолета: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите название производителя: ");
            Brand = Console.ReadLine();

            Console.WriteLine("Введите год выпуска: ");
            Year=Console.ReadLine();

            Console.WriteLine("Введите тип: ");
            Type = Console.ReadLine();

            
        }
        public void Print()
        {
            Console.WriteLine($"\nИдентификатор самолета: {Name}\nНазвание производителя: {Brand}\nГод выпуска: {Year}\nТип: {Type}");
        }

        public override string ToString()
        {
            return $"\nИдентификатор самолета: {Name}\nНазвание производителя: {Brand}\nГод выпуска: {Year}\nТип: {Type}";
        }
    }
}
