using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListExercise2
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //2 - depois os dados(id, nome e salario) de N funcionários.
        public override string ToString()
        {
            return "Id: " + Id +
                " Name: " + Name +
                " Salário: $ "+Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
