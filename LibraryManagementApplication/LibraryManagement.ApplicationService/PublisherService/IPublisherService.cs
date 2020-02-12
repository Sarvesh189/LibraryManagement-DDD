using LibraryManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Domain.Model.Publisher;

namespace LibraryManagement.ApplicationService.PublisherService
{
    public interface IPublisherService
    {
        IReadOnlyList<PublisherDto> GetAllPublishers();
        PublisherDto GetPublisherById(string Id);
    }

    public class PublisherService : IPublisherService
    {
        IRepository<Publisher> _publisherRepository = new PublisherRepository();
        public IReadOnlyList<PublisherDto> GetAllPublishers()
        {
            var publisherDtos = new List<PublisherDto>();

            var publishers = _publisherRepository.FindAll();

            publishers.ToList().ForEach((cp) =>
            {
                var pubDto = PublisherMapping.MapToPublisherDto(cp);
                publisherDtos.Add(pubDto);
            });

            return publisherDtos;
        }

        public PublisherDto GetPublisherById(string Id)
        {          
            var publisher = _publisherRepository.FindBy(Guid.Parse(Id));
            return PublisherMapping.MapToPublisherDto(publisher);
        }
    }
}
