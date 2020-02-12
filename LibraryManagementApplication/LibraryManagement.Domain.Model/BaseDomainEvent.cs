using LibraryManagement.Domain.Base;
using System;

namespace LibraryManagement.Domain.Model
{
    public abstract class BaseDomainEvent : IEvent
    {
        private Guid _eventId;

        private DateTime _publishedOn;


        protected BaseDomainEvent(Guid eventId)
        {
            if (eventId == null) throw new ArgumentNullException("eventId");
            _eventId = eventId;
            _publishedOn = DateTime.Now;

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

        public DateTime PublishedOn
        {
            get { return _publishedOn; }

            protected set { _publishedOn = value; }
        }

    }      
}