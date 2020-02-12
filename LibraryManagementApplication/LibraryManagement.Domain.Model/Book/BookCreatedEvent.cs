using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model.Book
{

    public class BookCreatedEvent : BaseDomainEvent
    {
        public Book NewBook { get; set; }

        public BookCreatedEvent(Book newBookObject) : base(Guid.NewGuid())
        {
            if (newBookObject == null) throw new ArgumentNullException("newBookObject");
            NewBook = newBookObject;
        }

    }

    public class BookDeletedEvent : BaseDomainEvent
    {
        public Book DeletedBook { get; set; }

        public BookDeletedEvent(Book deletedBook) : base(Guid.NewGuid())
        {
            if (deletedBook == null) throw new ArgumentNullException("deletedBook");
            DeletedBook = deletedBook;
        }
    }
}