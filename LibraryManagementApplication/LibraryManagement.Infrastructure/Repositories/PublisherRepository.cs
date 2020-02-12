﻿using LibraryManagement.Domain.Model.Publisher;
using LibraryManagement.Infrastructure.DAL;
using Entity = LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Infrastructure.Repositories.Mapping;
using System.Collections.Concurrent;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class PublisherRepository : IRepository<Publisher>
    {
         IContext<Entity.Publisher> _publisherContext = new PublisherContext();
         IContext<Entity.Book> _bookContext = new BookContext();
        //public Publisher this[object key] { get { throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Publisher item)
        {
            throw new NotImplementedException();
        }

        public IList<Publisher> FindAll()
        {
            var _publishers = _publisherContext.GetItems();

            var publishers = new List<Publisher>();

            var books = _bookContext.GetItems();

         _publishers.ForEach((currentPublisher) => {
              var pub = PublisherMapping.MapToPublisher(currentPublisher);
              var ebooks = books.FindAll(bk => Guid.Parse(bk.PublisherId)== pub.EntityIdentityKey);
                 if (ebooks != null && ebooks.Count() > 0)
                 {
                    ebooks.ForEach((bk) => {
                        pub.Books.Add(new Book() { BookId = Guid.Parse(bk.Id), title = bk.Title });
                    });
                 
                  }
             publishers.Add(pub);
            });
            return publishers.ToList();
        }

        public Publisher FindById(Guid key)
        {
            var epublisher = _publisherContext.GetItemById(Convert.ToString(key));
            var publisher = PublisherMapping.MapToPublisher(epublisher);
            publisher.Books.Add(new Book() { BookId = Guid.Parse(_bookContext.GetItems()[0].Id), title = _bookContext.GetItems()[0].Title });
            return publisher;
        }

        public void Remove(Publisher item)
        {
            throw new NotImplementedException();
        }

        public Publisher FindBy(Guid key)
        {
            return FindById(key);
        }

        public void Update(Publisher item)
        {
            throw new NotImplementedException();
        }
    }
}