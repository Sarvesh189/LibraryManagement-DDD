using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
   public class BookContext:IContext<Book>
    {   

        
        public bool Delete(Book dummyObject)
        {
           return StaticData.Delete(dummyObject);
        }

        public List<Book> GetDummyObjects()
        {
            return StaticData.GetDummyObjects();   
        }

        public bool Insert(Book dummyObject)
        {
            StaticData.Insert(dummyObject);
            return true;
        }

        public bool Update(Book dummyObject)
        {
            throw new NotImplementedException();
        }
    }
}
