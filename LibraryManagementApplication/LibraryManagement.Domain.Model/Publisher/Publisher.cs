using LibraryManagement.Domain.Base;
using LibraryManagement.Domain.Base.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model.Publisher
{
    public class Publisher : BaseEntity<Publisher>, IAggregate
    {
        private Publisher() : this(Guid.NewGuid())
        {
           
        }

        private Publisher(Guid Id):base(Id)
        {
            this.Books = new List<Book>();
        }

         public string Name { get; private set; }

        public string WebSite { get; private set; }

        public string Email { get; private set; }

        public Address Office { get; private set; }

        public IList<Book> Books { get; private set; }

        protected override void Validate()
        {

            if (string.IsNullOrEmpty(this.Name))
                throw new Exception("Publisher name can't be empty.");
            if (string.IsNullOrEmpty(this.Email))
                throw new Exception("Publisher email can't be empty.");
                      
        }

        public static Publisher Add(Guid id, string name, string webSite, string email, Address address, IList<Book> books)
        {
            var pub = new Publisher(id)
            {
                Name = name,
                Email = email,
                WebSite = webSite,
                Office = address,
                Books = books
            };
            return pub;
        }
        public static Publisher Add(string name, string webSite, string email, Address address, IList<Book> books)
        {
            var pub = new Publisher()
            {
                Name = name,
                Email = email,
                WebSite = webSite,
                Office = address,
                Books = books
            };
            return pub;
        }

        public void Update(string name, string website, string email)
        {
            Name = name;
            WebSite = website;
            Email = email;
        }
    }
}