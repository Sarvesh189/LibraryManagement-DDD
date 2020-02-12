using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model.Book
{
    public class Book : BaseEntity<Book>, IAggregate
    {
        private string title;
        private string _ISBN;
        private string language;
        private decimal price;
        private IList<Author> authors;
        private Publisher _publisher;

        private Book() : base(Guid.NewGuid())
        {
            
        }

        private Book(Guid id): base(id)
        {
            
        }

        public virtual Publisher Publisher { get { return _publisher; }  protected set { _publisher = value; } }

        public virtual string Title
        {
            get
            {
                return title;
            }

           protected set
            {
                title = value;
            }
        }

        public virtual string ISBN
        {
            get
            {
                return _ISBN;
            }

            protected set
            {
                _ISBN = value;
            }
        }

        public virtual string Language
        {
            get
            {
                return language;
            }

            protected set
            {
                language = value;
            }
        }



        public virtual decimal Price
        {
            get
            {
                return price;
            }

            protected set
            {
                price = value;
            }
        }

        public virtual IList<Author> Authors
        {
            get
            {
                return authors;
            }

            protected set
            {
                authors = value;
            }
        }

        protected override void Validate()
        {
            if (EntityIdentityKey == null || EntityIdentityKey == Guid.Empty)
                throw new InvalidBookException("Book unique id is null"); //throw domain exception
           // if (Authors == null || Authors.Count() < 1)
           //     throw new InvalidBookException("Book should have an author.");  //throw domain exception 
            if (Publisher == null || Publisher.Id == null)
                throw new InvalidBookException("Book should have a publisher.");
        }

        public static Book Create(string bTitle, string bISBN, string bLanguage, decimal bPrice, Publisher bPublisher,  IList<Author> bAuthors)
         {
           return Create(Guid.NewGuid(), bTitle, bISBN, bLanguage, bPrice, bPublisher, bAuthors);  
        }

        public static Book Create(Guid bId, string bTitle, string bISBN, string bLanguage, decimal bPrice, Publisher bPublisher, IList<Author> bAuthors)
        {
            var book = new Book()
            {
                EntityIdentityKey = bId,
                title = bTitle,
                ISBN = bISBN,
                language = bLanguage,
                price = bPrice,
                authors = bAuthors,
                _publisher = bPublisher
            };
            book.Validate();
           // RaiseEvent(new BookCreatedEvent(book));
            return book;
        }

        public void Update(string bTitle, string bISBN, string bLanguage, decimal bPrice)
        {
            Title = bTitle;
            ISBN = bISBN;
            Language = bLanguage;
            Price = bPrice;
        }
        public void RemoveBook()
        {
          //  RaiseEvent(new BookDeletedEvent(this));
        }
    }
}