using System;

namespace VectorReinforcementExercise2
{
     class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Bedroom { get; set; }

        public Student(string name, string email, int bedroom)
        {
            Name = name;
            Email = email;
            Bedroom = bedroom;
        }

        public override string ToString()
        {
            return  "Aluno: " + Name +
                    "\nEmail: " + Email +
                    "\nQuarto: " + Bedroom;
        }
    }
}
