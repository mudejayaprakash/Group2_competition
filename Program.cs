using System;

using System;

namespace USF_Library_Competition_Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person test
            var john = new Person("John Snow", "johnsnow@gmail.com", "LIB12345");
            Console.WriteLine(john);                   // "Name: John Snow, ID: LIB12345"
            Console.WriteLine($"Email: {john.Email}"); // "johnsnow@gmail.com"

            // Student test
            var akhil = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Console.WriteLine(akhil); // calls Student.ToString() if you added it

            // Update properties to prove it’s working
            akhil.Major = "Information Systems";
            akhil.GraduationYear = 2027;
            Console.WriteLine($"Updated: {akhil}");
        }
    }
}
