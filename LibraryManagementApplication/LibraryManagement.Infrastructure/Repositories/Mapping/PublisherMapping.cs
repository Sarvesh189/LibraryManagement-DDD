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

        public static Entity.Publisher MapToPublisherEntity(Publisher publisher)
        {
            var ePub = new Entity.Publisher()
            {
                Id = publisher.EntityIdentityKey.ToString(),
                Name = publisher.Name,
                WebSite = publisher.WebSite,
                Email = publisher.Email,
                Office = AddressMapping.MapToAddressEntity(publisher.Office)
            };
           return ePub;
        }
    }
}
