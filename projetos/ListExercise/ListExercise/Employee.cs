
using System.Globalization;


namespace ListExercise
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
    
        public override string ToString()
        {
            return  "Id: " + Id 
                    +"\nName: " + Name 
                    +"\nSalary: R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
