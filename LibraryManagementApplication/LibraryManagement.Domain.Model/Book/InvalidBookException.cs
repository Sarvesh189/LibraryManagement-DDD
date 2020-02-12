using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model.Book
{
    public class InvalidBookException : Exception
    {
        public InvalidBookException()
        {
        }

        public InvalidBookException(string message)
            : base(message)
        {
        }
       
    }
}