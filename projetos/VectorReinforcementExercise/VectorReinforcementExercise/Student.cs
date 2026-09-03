using System;


namespace VectorReinforcementExercise
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
            return  "Name: " + Name 
                    +"\nEmail: " + Email
                    +"\nBedroom: " +Bedroom;
        }
    }
}
