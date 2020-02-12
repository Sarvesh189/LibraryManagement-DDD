using LibraryManagement.Domain.Model.Book;
using LibraryManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ApplicationService.BookService
{
    public interface IBookService
    {
        IList<BookDto> GetAllBooks();
        void Add(BookDto bookDto);
        void Update(BookDto bookDto);
        void Remove(BookDto bookDto);
        BookDto GetBookById(Guid bookId);
        IReadOnlyCollection<BookDto> GetBooksByAuthor(IReadOnlyList<AuthorDto> author);

        IReadOnlyCollection<BookDto> GetBooksByPublisher(IReadOnlyList<PublisherDto> publisherDtos);
    }
    
    public class BookService : IBookService
    {
        //injectable candidate
        IRepository<Book> _bookRepository = new BookRepository();

        public void Add(BookDto bookDto)
        {
            var authors = new List<Author>();
            var book = Book.Create(bookDto.Title, bookDto.ISBN, bookDto.Language, bookDto.Price, new Publisher(bookDto.Publisher.Id, bookDto.Publisher.Name), authors);
            _bookRepository.Add(book);
        }

        public IList<BookDto> GetAllBooks()
        {
             var bookDtos = new List<BookDto>();
             var books = _bookRepository.FindAll();
             foreach (var book in books)
                {
                    var bookDto = BookMappingConfiguration.MapToBookDto(book);
                    bookDtos.Add(bookDto);
                }
             
            return bookDtos.OrderBy(bk=>bk.Title).ToList();
        }

        public BookDto GetBookById(Guid bookId)
        {
           var book = _bookRepository.FindBy(bookId);

            return BookMappingConfiguration.MapToBookDto(book);
        }

        public IReadOnlyCollection<BookDto> GetBooksByAuthor(IReadOnlyList<AuthorDto> author)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<BookDto> GetBooksByPublisher(IReadOnlyList<PublisherDto> publisherDtos)
        {
            throw new NotImplementedException();
        }

        public void Remove(BookDto bookDto)
        {

            var book = _bookRepository.FindBy(bookDto.BookId);
            book.RemoveBook();
            _bookRepository.Remove(book);
        }

        public void Update(BookDto bookDto)
        {
            var book = _bookRepository.FindBy(bookDto.BookId);
            book.Update(bookDto.Title, bookDto.ISBN, bookDto.Language, bookDto.Price);
            _bookRepository.Update(book);
        }
    }
}
