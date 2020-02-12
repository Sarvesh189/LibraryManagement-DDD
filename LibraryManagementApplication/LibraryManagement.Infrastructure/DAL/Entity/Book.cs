using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL.Entity
{
    public class Book 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }   
        
        public string PublisherId { get; set; }    
    }
}