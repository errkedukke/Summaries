using System.Collections.Generic;

namespace Summaries.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookByID (int id);
        void AddBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}