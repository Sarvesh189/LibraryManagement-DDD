using LibraryManagement.Domain.Model;
using LibraryManagement.Infrastructure.DAL;
using LibraryManagement.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        //injectable candidate
        IContext<Book> _bookContext = new BookContext();

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
            _bookContext.Insert(item);
            foreach (var domainevent in item.EventList)
            {
                DomainEventManager.Publish<BookCreatedEvent>(domainevent as BookCreatedEvent);
            }
        }

        public IList<Book> FindAll()
        {
            return _bookContext.GetDummyObjects();
        }

        public Book FindBy(Guid key)
        {
            return _bookContext.GetDummyObjects().FirstOrDefault(b => b.EntityIdentityKey == key);
        }

        public void Remove(Book item)
        {
            _bookContext.Delete(item);
            foreach (var domainevent in item.EventList)
            {
                DomainEventManager.Publish<BookDeletedEvent>(domainevent as BookDeletedEvent);
               // item.RemoveEvent(domainevent);
            }
            item.ClearEvent();
        }
    }
}
