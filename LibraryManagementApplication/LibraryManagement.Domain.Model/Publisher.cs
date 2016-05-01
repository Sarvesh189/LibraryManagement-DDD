using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model
{
    public class Publisher : EntityBase<Publisher>,IAggregate
    {
        private string _name;
        private Address _address;
        private string _url;
        private List<Book> _bookList;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Address Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Url
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
            }
        }

        public List<Book> BookList
        {
            get
            {
                return _bookList;
            }

            set
            {
                _bookList = value;
            }
        }

        public Publisher(Guid publisherIdentityKey) : base(publisherIdentityKey) {
            BookList = new List<Book>();
            
        }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}