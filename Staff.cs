using System;

namespace USF_Library_Competition_Week6
{
    public class Staff : Person
    {
        public string Position { get; set; } = "";
        public string Department { get; set; } = "";

        // Default constructor
        public Staff() { }

        // Constructor calling base class (Person)
        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }

        // Override ToString() to include Staff details
        public override string ToString()
        {
            return base.ToString() + $", Position: {Position}, Department: {Department}";
        }
    }
}
