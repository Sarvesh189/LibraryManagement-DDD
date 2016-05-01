using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL
{
    public class StaticData
    {
        private static List<Book> bookList = new List<Book>() { new Book(Guid.NewGuid()) { Title = "CSharp Cookbook",  Price = 3233, Paperback = 564, Language = "English", ISBN = "12121212" },
            new Book(Guid.NewGuid()) { Title = "FSharp Cookbook",  Price = 3233, Paperback = 564, Language = "English", ISBN = "12121212" },
            new Book(Guid.NewGuid()) { Title = "Angular Cookbook",  Price = 333, Paperback = 564, Language = "English", ISBN = "12121212" },
            new Book(Guid.NewGuid()) { Title = "JavaScript Cookbook",  Price = 2233, Paperback = 564, Language = "English", ISBN = "12121212" }
        };

        public static bool Delete(Book dummyObject)
        {
           return bookList.Remove(dummyObject);
        }

        public static List<Book> GetDummyObjects()
        {
            return bookList;
        }

        public static bool Insert(Book dummyObject)
        {
            bookList.Add(dummyObject);
            return true;
        }

        public bool Update(Book dummyObject)
        {
            throw new NotImplementedException();
        }
    }
}
