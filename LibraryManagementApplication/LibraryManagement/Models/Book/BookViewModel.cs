using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.Models.Book
{
    public class BookViewModel
    {
       // public Guid BookId { get; set; }
         public string Title
        {
            get;
            set;
        }

        public string ISBN
        {
            get;set;
        }

        public string SelectedPublisher { get; set; }
        public IEnumerable<SelectListItem> PublisherList
        {
            get; set;
        }

        public string Language
        {
            get; set;
        }

        public int Paperback
        {
            get; set;
        }

        public decimal Price { get; set; }
    }
}