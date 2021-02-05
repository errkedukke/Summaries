using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetBookByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(int id, Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}