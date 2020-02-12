using LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Infrastructure.DAL
{
    public static class BookStaticData
    {
        private static List<Book> bookList = new List<Book>() { new Book() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6381", Title = "CSharp Cookbook",  Price = 3233, Language = "English", ISBN = "12121212", PublisherId = "2E2601B0-2259-494A-949E-F73C3BFF6341" },
            new Book() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6382", Title = "FSharp Cookbook",  Price = 3233, Language = "French", ISBN = "551212", PublisherId = "2E2601B0-2259-494A-949E-F73C3BFF6341"  },
            new Book() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6383", Title = "Angular Cookbook",  Price = 333, Language = "English", ISBN = "9651212", PublisherId = "2E2601B0-2259-494A-949E-F73C3BFF6342"  },
            new Book() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6384", Title = "JavaScript Cookbook",  Price = 2233, Language = "English", ISBN = "121854", PublisherId = "2E2601B0-2259-494A-949E-F73C3BFF6342"  }
        };

        public static bool Delete(Book book)
        {
           return bookList.Remove(book);
        }

        public static List<Book> GetBooks()
        {
           return bookList;
        }

        public static bool Insert(Book book)
        {
            bookList.Add(book);
            return true;
        }

        public static bool Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
