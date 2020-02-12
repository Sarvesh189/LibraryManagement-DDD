using LibraryManagement.Domain.Model;
using LibraryManagement.Domain.Model.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ApplicationService.BookService
{
    public static class BookMappingConfiguration
    {
        //public static Book MapToBook(BookDto bookDto)
        //{
        //    var book = Book.CreateNewBook();
        //    book.ISBN = bookDto.ISBN;
        //    book.Language = bookDto.Language;
        //    book.Price = bookDto.Price;
        //    //book.Publisher = bookDto.Publisher;
        //    book.Title = bookDto.Title;
        //    return book;
        //}

        public static BookDto MapToBookDto(Book book)
        {
            var bookDto = new BookDto();
            bookDto.BookId = book.EntityIdentityKey;
            bookDto.ISBN = book.ISBN;
            bookDto.Language = book.Language;
            bookDto.Price = book.Price;
            bookDto.Publisher = new PublisherDto() { Id = book.Publisher.Id, Name = book.Publisher.Name };
            bookDto.Title = book.Title;            
            return bookDto;
        }
    }
}
