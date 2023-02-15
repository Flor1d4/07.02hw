using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    class Plane
    {
        private string Name { get; set; }
        private int Year { get; set; }
        private string Type { get; set; }

        private static string Brand;

        public Plane() { }
        public Plane(string name, int year, string type)
        {
            Name = name;
            Year = year;
            Type = type;
        }

        static Plane()
        {
            Console.WriteLine("Введите бренд: ");
            Brand = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($"Plane name: {Name}\nBrand: {Brand}\nYear: {Year}\nType: {Type}");
        }

        public override string ToString()
        {
            return $"Plane name: {Name}\nBrand: {Brand}\nYear: {Year}\nType: {Type}";
        }
    }
}
