using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ApplicationService.BookService
{
    public class BookService : IBookService
    {
        public void AddBook(BookDto bookDto)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<BookDto> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookDto GetBookById(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<BookDto> GetBooksByAuthor(IReadOnlyList<AuthorDto> author)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<BookDto> GetBooksByPublisher(IReadOnlyList<PublisherDto> publisherDtos)
        {
            throw new NotImplementedException();
        }

        public void RemoveBook(BookDto bookDto)
        {
            throw new NotImplementedException();
        }
    }
}
