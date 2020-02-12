using LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
   public class BookContext:IContext<LibraryManagement.DAL.Entity.Book>
    {
        public void Add(Domain.Model.Book.Book item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string bookId)
        {
           var book = BookStaticData.GetBooks().FirstOrDefault(bk => bk.Id.ToUpper() == bookId.ToUpper());
           return BookStaticData.Delete(book);
        }

        public LibraryManagement.DAL.Entity.Book GetItemById(string Id)
        {
            return BookStaticData.GetBooks().FirstOrDefault(bk => bk.Id.ToUpper() == Id.ToUpper());
        }

        public List<LibraryManagement.DAL.Entity.Book> GetItems()
        {
            return BookStaticData.GetBooks();   
        }

        public bool Insert(LibraryManagement.DAL.Entity.Book book)
        {
            BookStaticData.Insert(book);
            return true;
        }

        public bool Update(LibraryManagement.DAL.Entity.Book book)
        {
            throw new NotImplementedException();
        }
    }
}
