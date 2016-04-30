using LibraryManagement.ApplicationService.DTO;
using LibraryManagement.ApplicationService.Mapping;
using LibraryManagement.Domain.Model;
using LibraryManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.ApplicationService
{
    public interface IBookService
    {
        IReadOnlyCollection<BookDto> GetBooks();
        void AddBook(BookDto bookDto);
        void RemoveBook(BookDto bookDto);
        BookDto GetBookById(Guid bookId);

    }
    public class BookService : IBookService
    {
        //injectable candidate
        IRepository<Book> _bookRepository = new BookRepository();

        public void AddBook(BookDto bookDto)
        {
            Book book = MappingConfiguration.MapToBook(bookDto);
            book = book.AddNewBook();
            _bookRepository.Add(book);
        }

        public BookDto GetBookById(Guid bookId)
        {
          var book =  _bookRepository.FindBy(bookId);
            return MappingConfiguration.MapToBookDto(book);
        }

        public IReadOnlyCollection<BookDto> GetBooks()
        {
            var bookdtos = new List<BookDto>();
          var bookList =  _bookRepository.FindAll();
            foreach (var book in bookList)
            {
                bookdtos.Add(MappingConfiguration.MapToBookDto(book));
            }
            return bookdtos.AsReadOnly();
        }

        public void RemoveBook(BookDto bookDto)
        {

           var book = _bookRepository.FindBy(bookDto.BookId);
            book.RemoveBook();
            _bookRepository.Remove(book);
        }
    }

}
