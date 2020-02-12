using LibraryManagement.Domain.Model.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ApplicationService.PublisherService
{
   public class PublisherMapping
    {
        public static PublisherDto MapToPublisherDto(Publisher publisher)
        {
            var publisherDto = new PublisherDto();
            publisherDto.Id = publisher.EntityIdentityKey;
            publisherDto.Name = publisher.Name;
            publisherDto.OfficeAddress = publisher.Office.ToString();
            publisherDto.WebSite = publisher.WebSite;
            publisherDto.Email = publisher.Email;
            publisherDto.Books = new List<BookDto>();
            foreach (var book in publisher.Books)
            {
                publisherDto.Books.Add(new BookDto() { Id = Convert.ToString(book.BookId), Title = book.title });
            }
            return publisherDto;
        }
    }
}
