using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model
{
    public class Author : EntityBase<Author>, IAggregate
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private Address _address;
        private List<Book> _bookList;

        public Author(Guid authorIdentityKey) : base(authorIdentityKey)
        {
            _bookList = new List<Book>();
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }

            set
            {
                _middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
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

        public string FullName {
           get
            {
                return string.Format("{0} {1} {2}", this._firstName, this._middleName, this._lastName);
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}