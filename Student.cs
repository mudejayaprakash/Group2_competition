using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USF_Library_Competition_Week6
{
    public class Student : Person
    {
        public string Major { get; set; } = "";
        public int GraduationYear { get; set; }

        public Student() { }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }

        public override string ToString()
            => $"Name: {Name}, ID: {Id}, Major: {Major}, Graduation: {GraduationYear}";
    }
}

