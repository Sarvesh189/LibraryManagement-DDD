using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Book: EntityBase<Book>, IAggregate
    {
        private string _title;
        private string _ISBN;
        
        private string _language;
        private int _paperback;
        private decimal _price;
        private List<Author> _authors;
        private Publisher _publisher;

        public Book() : this(Guid.Empty) {                  

        }

        public Book(Guid uniqueId): base(uniqueId)
        {
            _authors = new List<Author>();
        }

        public Publisher Publisher { get { return _publisher; } set { _publisher = value; } }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string ISBN
        {
            get
            {
                return _ISBN;
            }

            set
            {
                _ISBN = value;
            }
        }       

        public string Language
        {
            get
            {
                return _language;
            }

            set
            {
                _language = value;
            }
        }

        public int Paperback
        {
            get
            {
                return _paperback;
            }

            set
            {
                _paperback = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public List<Author> Authors
        {
            get
            {
                return _authors;
            }

            set
            {
                _authors = value;
            }
        }

        protected override void Validate()
        {
            if (this.EntityIdentityKey == null || this.EntityIdentityKey == Guid.Empty)
                throw new Exception("Book unique id is null");
        }

        public Book AddNewBook()
        {
            this.EntityIdentityKey = Guid.NewGuid();
            this.Validate();
            this.RaiseEvent(new BookCreatedEvent(this));
            return this;
        }

        public void RemoveBook()
        {
            RaiseEvent(new BookDeletedEvent(this));
        }
    }
    
}