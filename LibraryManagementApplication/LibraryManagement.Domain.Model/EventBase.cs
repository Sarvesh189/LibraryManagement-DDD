using LibraryManagement.Domain.Base;
using System;

namespace LibraryManagement.Domain.Model
{
    public abstract class EventBase : IDomainEvent
    {
        private Guid _eventId;


        protected EventBase(Guid eventId)
        {
            if (eventId == null) throw new ArgumentNullException("eventId");
            _eventId = eventId;

        }

        public Guid EventId
        {
            get
            {
                return _eventId;
            }

            protected set
            {
                _eventId = value;
            }
        }

    }

    public class BookCreatedEvent : EventBase
    {
        public Book NewBook { get; set; }
        
        public BookCreatedEvent(Book newbookobject) : base(Guid.NewGuid())
        {
            if (newbookobject == null) throw new ArgumentNullException("newbookobject");
                NewBook = newbookobject;
        }

    }

    public class BookDeletedEvent : EventBase
    {
        public Book DeletedBook { get; set; }

        public BookDeletedEvent(Book deletedBook) : base(Guid.NewGuid())
        {
            if (deletedBook == null) throw new ArgumentNullException("deletedBook");
            DeletedBook = deletedBook;
        }
    }



   
}