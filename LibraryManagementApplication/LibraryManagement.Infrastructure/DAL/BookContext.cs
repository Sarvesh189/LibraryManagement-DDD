using LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
   public class BookContext:IContext<Book>
    {   
        
        
        public bool Delete(Book book)
        {
           return BookStaticData.Delete(book);
        }

        public Book GetItemById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetItems()
        {
            return BookStaticData.GetBooks();   
        }

        public bool Insert(Book book)
        {
            BookStaticData.Insert(book);
            return true;
        }

        public bool Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
