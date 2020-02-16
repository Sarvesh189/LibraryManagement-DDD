using LibraryManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Domain.Model.Publisher;
using LibraryManagement.Domain.Base.SharedKernel;
using LibraryManagement.Domain.Base.RepositoryContract;

namespace LibraryManagement.ApplicationService.PublisherService
{
    public interface IPublisherService
    {
        IReadOnlyList<PublisherDto> GetAllPublishers();
        PublisherDto GetPublisherById(Guid Id);
        void Update(PublisherDto publisher);
        void Remove(PublisherDto publisher);
        void Add(PublisherDto publisher);
    }

    public class PublisherService : IPublisherService
    {
        IRepository<Publisher> _publisherRepository = new PublisherRepository();

        public void Add(PublisherDto publisher)
        {
           var pub = Publisher.Add(publisher.Name, publisher.WebSite, publisher.Email, new Address("", "", "", "",""), new List<Book>());
            _publisherRepository.Add(pub);
        }

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

        public PublisherDto GetPublisherById(Guid Id)
        {          
            var publisher = _publisherRepository.FindBy(Id);
            return PublisherMapping.MapToPublisherDto(publisher);
        }

        public void Remove(PublisherDto publisher)
        {
           var pub = _publisherRepository.FindBy(publisher.Id);
            _publisherRepository.Remove(pub);
        }

        public void Update(PublisherDto publisherDto)
        {
            var pub = _publisherRepository.FindBy(publisherDto.Id);
            pub.Update(publisherDto.Name, publisherDto.WebSite, publisherDto.Email);
            _publisherRepository.Update(pub);
        }
    }
}
