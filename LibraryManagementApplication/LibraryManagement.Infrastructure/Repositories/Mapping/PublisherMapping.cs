using LibraryManagement.Domain.Base.SharedKernel;
using LibraryManagement.Domain.Model.Publisher;
using System;
using System.Collections.Generic;
using Entity = LibraryManagement.DAL.Entity;

namespace LibraryManagement.Infrastructure.Repositories.Mapping
{
   public static class PublisherMapping
    {
        public static Publisher MapToPublisher(Entity.Publisher publisher)
        {
            var pb = Publisher.Add(Guid.Parse(publisher.Id), publisher.Name, publisher.WebSite, publisher.Email, new Address(publisher.Office.Street, publisher.Office.City,publisher.Office.State, publisher.Office.ZipCode, publisher.Office.Country), new List<Book>());
            return pb;
        }
    }
}
