using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    internal class Employee
    {
        private string Fullname { get; set; }
        private string Birthday { get; set; }
        private string Number { get; set; }
        private string Description { get; set; }
        private string Type { get; set; }
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
            Console.WriteLine("Введите почту: ");
            Email = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($"Fullname: {Fullname}\nBirthday: {Birthday}\nNumber: {Number}\nEmail: {Email}\nDescription: {Description}\nType: {Type}");
        }
        public override string ToString()
        {
            return $"Fullname: {Fullname}\nBirthday: {Birthday}\nNumber: {Number}\nEmail: {Email}\nDescription: {Description}\nType: {Type}";
        }
    }
}
