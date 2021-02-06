using System.Collections.Generic;
using System.Linq;

namespace Summaries.Data
{
    public class BookService : IBookService
    {
        public void AddBook(Book book)
        {
            Data.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            
            if(book != null)
            {
                Data.Books.Remove(book);
            }
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetBookByID(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id );
            return book;
        }

        public void UpdateBook(int id, Book book)
        {
            var oldBook = Data.Books.FirstOrDefault(b => b.Id == id);

            if(oldBook != null)
            {
                oldBook.Title = book.Title;
                oldBook.Author = book.Author;
                oldBook.Description = book.Description;
                oldBook.DateStart = book.DateStart;
                oldBook.DateRead = book.DateRead;
                oldBook.Rate = book.Rate;
            }
        }
    }
}