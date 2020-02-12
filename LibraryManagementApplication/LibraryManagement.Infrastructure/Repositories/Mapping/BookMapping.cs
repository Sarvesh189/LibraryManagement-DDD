using LibraryManagement.Domain.Model.Book;
using Entity = LibraryManagement.DAL.Entity;

namespace LibraryManagement.Infrastructure.Repositories.Mapping
{
   public static class BookMapping
    {
        public static Entity.Book MapToBookEntity(Book book)
        {
            var bk = new Entity.Book();
            bk.Id = book.EntityIdentityKey.ToString();
            bk.Title = book.Title;
            bk.ISBN = book.ISBN;
            bk.Language = book.Language;
            bk.Price = book.Price;
            bk.Title = book.Title;
            bk.PublisherId = book.Publisher.Id.ToString();
            return bk;
        }
    }
}
