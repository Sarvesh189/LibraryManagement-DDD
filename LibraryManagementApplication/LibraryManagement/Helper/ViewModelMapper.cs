using LibraryManagement.ApplicationService.DTO;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Helper
{
    public class ViewModelMapper
    {
        public static BookViewModel MapToBookViewModel(BookDto bookDto)
        {
            var book = new BookViewModel();
            book.BookId = bookDto.BookId;
            book.ISBN = bookDto.ISBN;
            book.Language = bookDto.Language;
            book.Paperback = bookDto.Paperback;
            book.Price = bookDto.Price;
            book.Publisher = bookDto.Publisher;
            book.Title = bookDto.Title;
            return book;
        }
    }
}