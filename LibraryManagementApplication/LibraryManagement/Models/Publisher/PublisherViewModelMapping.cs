using LibraryManagement.ApplicationService.PublisherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LibraryManagement.Models.Publisher
{
    public class PublisherViewModelMapping
    {
        public static PublisherViewModel Map(PublisherDto publisherDto)
        {
            var pubvm = new PublisherViewModel();
            pubvm.Name = publisherDto.Name;
            pubvm.WebSite = publisherDto.WebSite;
            pubvm.Email = publisherDto.Email;
            pubvm.Office = publisherDto.OfficeAddress;
            pubvm.Books = new List<Book>();
            publisherDto.Books.ToList().ForEach((cb) =>
            {
                pubvm.Books.Add(new Book() { Id = cb.Id, Title = cb.Title });
            });

            return pubvm;
        }

    }
}