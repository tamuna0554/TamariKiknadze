using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task07
{
    public class Library
    {
        private List<Book> books = new List<Book>(); 

       
        public int Count
        {
            get { return books.Count; }
        }


        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"wigni '{book.Title}' damatebulia.");
        }

        public void RemoveBook(string title)
        {
            var bookToRemove = books.FirstOrDefault(b => b.Title == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"wigni '{title}' washlilia.");
            }
            else
            {
                Console.WriteLine($"wigni '{title}' ar moidzebna.");
            }
        }

        
        public List<Book> FindBook(string title)
        {
            var foundBooks = books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            return foundBooks;
        }

     
        public void PrintBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("bibliotekashi wigni ar aris.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author} ({book.Year})");
                }
            }
        }
    }

}
