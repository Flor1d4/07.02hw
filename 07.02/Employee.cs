using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    internal class Employee
    {
        private static string Fullname{ get; set; }
        private static  string Birthday { get; set; }
        private static string Number { get; set; }
        private static string Description { get; set; }
        private static string Type { get; set; }

        private static string Email;
        public Employee() { }
        public Employee(string fullname, string birthday, string number, string description, string type)
        {
            Fullname = fullname;
            Birthday = birthday;
            Number = number;
            Description = description;
            Type = type;
        }

        static Employee()
        {
            Console.WriteLine("Введите Имя: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: ");
            Birthday= Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            Number = Console.ReadLine();
            Console.WriteLine("Введите описание: ");
            Description = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            Type = Console.ReadLine();
            Console.WriteLine("Введите почту: ");
            Email = Console.ReadLine();                 
        }

        public void Print()
        {
            Console.WriteLine($"\nИмя: {Fullname}\nДата Рождения: {Birthday}\nНомер телефона: {Number}\nИмейл: {Email}\nОписание: {Description}\nДолжность: {Type}");
        }

        public override string ToString()
        {
            return $"\nИмя: {Fullname}\nДата Рождения: {Birthday}\nНомер телефона: {Number}\nИмейл: {Email}\nОписание: {Description}\nДолжность: {Type}";
        }
    }
}
