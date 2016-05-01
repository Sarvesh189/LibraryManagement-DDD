using LibraryManagement.ApplicationService.DTO;
using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.ApplicationService.Mapping
{
    public class MappingConfiguration
    {
        public static Member MapMemberDtoToMember(MemberDto memberDto)
        {
            var member = new Member(Guid.NewGuid());
            member.FirstName = memberDto.FirstName;
            member.MiddleName = memberDto.MiddelName;
            member.LastName = memberDto.LastName;
            member.Age = memberDto.Age;
            member.Address = new Address(memberDto.Address.Street, memberDto.Address.City, memberDto.Address.State, memberDto.Address.Zipcode);
            return member;
        }

        public static Book MapToBook(BookDto bookDto)
        {
            var book = new Book();
           
            book.ISBN = bookDto.ISBN;
            book.Language = bookDto.Language;
            book.Paperback = bookDto.Paperback;
            book.Price = bookDto.Price;
            //book.Publisher = bookDto.Publisher;
            book.Title = bookDto.Title;
            return book;
        }
        public static BookDto MapToBookDto(Book book)
        {
            var bookDto = new BookDto();
            bookDto.BookId = book.EntityIdentityKey;
            bookDto.ISBN = book.ISBN;
            bookDto.Language = book.Language;
            bookDto.Paperback = book.Paperback;
            bookDto.Price = book.Price;
          //  bookDto.Publisher = book.Publisher;
            bookDto.Title = book.Title;
            return bookDto;
        }

    }
}
