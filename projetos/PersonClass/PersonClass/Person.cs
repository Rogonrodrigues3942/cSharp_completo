using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PersonClass
{
    class Person
    {
        public string Name { get; set; }
        public DateOnly Born { get; set; }
        public string City { get; set; }

        public double Salary { get; set; }

        public Person(string name, DateOnly born, string city, double salary)
        {
            Name = name;
            Born = born;
            City = city;
            Salary = salary;
        }

        public override string ToString()
        {
            return "\nNome: " + Name +
                    "  Nascimento: " + Born +
                    "  Cidade: " + City +
                    "  Salário: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
