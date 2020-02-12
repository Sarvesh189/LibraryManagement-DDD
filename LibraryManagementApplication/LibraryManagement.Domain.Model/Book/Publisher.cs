using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model.Book
{
    public class Publisher
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Publisher(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}