using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Models.Publisher
{
    public class PublisherViewModel
    {
        public string Name { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public string Office { get; set; }

        public IList<Book> Books { get; set; }
    }
}