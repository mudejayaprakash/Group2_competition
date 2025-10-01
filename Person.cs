using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USF_Library_Competition_Week6
{
    public class Person
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Id { get; set; } = "";

        public Person() { }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            Id = id;
        }

        public override string ToString() => $"Name: {Name}, ID: {Id}";
    }
}
