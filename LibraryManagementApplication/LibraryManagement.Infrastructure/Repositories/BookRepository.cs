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
            // Entity.Book book = new 
           // _bookContext.Insert(item);
            //foreach (var domainevent in item.EventList)
            //{
            //    DomainEventManager.Publish<BookCreatedEvent>(domainevent as BookCreatedEvent);
            //}
        }

        public IList<Book> FindAll()
        {
            var books = _bookContext.GetItems();
            var publishers = _publisherContext.GetItems();
            var _books = new List<Book>();

            Parallel.ForEach(books, (currentBook) => {
               _books.Add(BookMapping.MapToBook(currentBook));
            });
            
            for (int index = 0; index < _books.Count; index++)
            {
                _books[index].Publisher = new Publisher();
                _books[index].Publisher.Name = publishers[index].Name;
                _books[index].Publisher.Id =   Guid.Parse(publishers[index].Id);
            }
            return _books;
        }

        public Book FindBy(Guid key)
        {
            //  return _bookContext.GetItems().FirstOrDefault(b => b.Id == key.ToString());
            return null;
        }

        public void Remove(Book item)
        {
           // _bookContext.Delete(item);
            //foreach (var domainevent in item.EventList)
            //{
            //    DomainEventManager.Publish<BookDeletedEvent>(domainevent as BookDeletedEvent);
            //   // item.RemoveEvent(domainevent);
            //}
            //item.ClearEvent();
        }
    }
}
