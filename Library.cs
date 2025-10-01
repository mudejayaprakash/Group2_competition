using System;
using System.Collections.Generic;
using System.Linq;

namespace USF_Library_Competition_Week6
{
    public class Library
    {
        private readonly List<Book> _books = new();
        private readonly List<Person> _patrons = new();

        public void AddBook(Book book)
        {
            if (book is null) throw new ArgumentNullException(nameof(book));
            _books.Add(book);
        }

        public void AddPatron(Person person)
        {
            if (person is null) throw new ArgumentNullException(nameof(person));
            _patrons.Add(person);
        }

        public Book? GetBookByTitle(string title) =>
            _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        public bool TryBorrowBook(string title)
        {
            var book = GetBookByTitle(title);
            return book != null && book.BorrowBook();
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var b in _books)
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Available Copies: {b.AvailableCopies}");
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var p in _patrons)
                Console.WriteLine($"Name: {p.Name}, ID: {p.ID}");
            Console.WriteLine();
        }
    }
}

