using LibraryManagement.Domain.Model.Book;
using LibraryManagement.Infrastructure.DAL;
using Entity = LibraryManagement.DAL.Entity;
using LibraryManagement.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.Infrastructure.Repositories.Mapping;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        //injectable candidate
        IContext<Entity.Book> _bookContext = new BookContext();
        IContext<Entity.Publisher> _publisherContext = new PublisherContext();

        public Book this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Book item)
        {
            Entity.Book book = BookMapping.MapToBookEntity(item);
           

           _bookContext.Insert(book);

            //foreach (var domainevent in item.EventList)
            //{
            //    DomainEventManager.Publish<BookCreatedEvent>(domainevent as BookCreatedEvent);
            //}
        }

        public IList<Book> FindAll()
        {
            var books = _bookContext.GetItems();
            var _books = new List<Book>();
             books.ForEach((cb) => {
                 var publisher = _publisherContext.GetItemById(cb.PublisherId);
                 _books.Add(
                   Book.Create(Guid.Parse(cb.Id), cb.Title, cb.ISBN,  cb.Language, cb.Price, new Publisher(Guid.Parse(publisher.Id), publisher.Name), null)
                );
            });
            

            return _books;
        }

        public Book FindBy(Guid key)
        {
            var eBook = _bookContext.GetItemById(key.ToString());
            var epublisher = _publisherContext.GetItemById(eBook.PublisherId);
           return Book.Create(Guid.Parse(eBook.Id), eBook.Title, eBook.ISBN, eBook.Language, eBook.Price, new Publisher(Guid.Parse(epublisher.Id), epublisher.Name), new List<Author>());
        }

        public void Remove(Book item)
        {
            _bookContext.Delete(item.EntityIdentityKey.ToString());
            //foreach (var domainevent in item.EventList)
            //{
            //    DomainEventManager.Publish<BookDeletedEvent>(domainevent as BookDeletedEvent);
            //   // item.RemoveEvent(domainevent);
            //}
            //item.ClearEvent();
        }

        public void Update(Book item)
        {
            _bookContext.Delete(item.EntityIdentityKey.ToString());
            _bookContext.Insert(BookMapping.MapToBookEntity(item));
        }
    }
}
