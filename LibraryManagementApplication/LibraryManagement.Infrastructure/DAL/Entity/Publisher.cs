using LibraryManagement.Domain.Base;
using LibraryManagement.Domain.Base.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL.Entity
{
    public class Publisher
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public Address Office { get; set; }


    }


}