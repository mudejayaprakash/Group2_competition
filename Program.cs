using System;

namespace USF_Library_Competition_Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person("John Snow", "johnsnow@gmail.com", "LIB12345");
            Console.WriteLine(john);                   // "Name: John Snow, ID: LIB12345"
            Console.WriteLine($"Email: {john.Email}"); // "johnsnow@gmail.com"
            
            var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            Console.WriteLine("---- Staff Example ----");
            Console.WriteLine(staff1);
            Console.WriteLine($"Email: {staff1.Email}");
        }
        
    }
}
