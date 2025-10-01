using System;

namespace USF_Library_Competition_Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person test
            var john = new Person("John Snow", "johnsnow@gmail.com", "LIB12345");
            Console.WriteLine(john);
            Console.WriteLine($"Email: {john.Email}");

            // Staff test
            var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            Console.WriteLine("---- Staff Example ----");
            Console.WriteLine(staff1);
            Console.WriteLine($"Email: {staff1.Email}");

            // Student test
            var akhil = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Console.WriteLine("---- Student Example ----");
            Console.WriteLine(akhil);

            // Update properties
            akhil.Major = "Information Systems";
            akhil.GraduationYear = 2027;
            Console.WriteLine($"Updated: {akhil}");

            // Library demo
            var library = new Library();
            library.AddBook(new Book("C# Basics", "Smith", "ISBN111", 2));
            library.AddBook(new Book("OOP Concepts", "Jones", "ISBN222", 1));

            library.AddPatron(john);
            library.AddPatron(staff1);
            library.AddPatron(akhil);

            Console.WriteLine("\n---- Library Books ----");
            library.DisplayBooks();

            Console.WriteLine("---- Library Patrons ----");
            library.DisplayPatrons();

            Console.WriteLine("Borrowing 'C# Basics' twice:");
            Console.WriteLine(library.TryBorrowBook("C# Basics") ? "Borrowed!" : "Not available.");
            Console.WriteLine(library.TryBorrowBook("C# Basics") ? "Borrowed!" : "Not available.");
            Console.WriteLine(library.TryBorrowBook("C# Basics") ? "Borrowed!" : "Not available."); // should fail

            Console.WriteLine("\n---- After Borrowing ----");
            library.DisplayBooks();
        }
    }
}
