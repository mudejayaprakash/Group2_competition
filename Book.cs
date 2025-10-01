using System;

namespace USF_Library_Competition_Week6
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public int AvailableCopies { get; private set; }

        public Book(string title, string author, string isbn, int availableCopies)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required.", nameof(title));
            if (string.IsNullOrWhiteSpace(author)) throw new ArgumentException("Author is required.", nameof(author));
            if (string.IsNullOrWhiteSpace(isbn)) throw new ArgumentException("ISBN is required.", nameof(isbn));
            if (availableCopies < 0) throw new ArgumentOutOfRangeException(nameof(availableCopies), "Copies cannot be negative.");

            Title = title.Trim();
            Author = author.Trim();
            ISBN = isbn.Trim();
            AvailableCopies = availableCopies;
        }

        /// <summary>
        /// Attempts to borrow one copy.
        /// Returns true if successful; false if none are available.
        /// </summary>
        public bool BorrowBook()
        {
            if (AvailableCopies <= 0) return false;
            AvailableCopies--;
            return true;
        }

        public override string ToString()
            => $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
    }
}
