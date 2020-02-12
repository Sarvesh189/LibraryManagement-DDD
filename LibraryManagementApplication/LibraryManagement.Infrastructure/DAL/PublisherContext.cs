using LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL
{
    public class PublisherContext : IContext<Publisher>
    {
        public bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetItems()
        {
            return PublisherStaticData.GetPublishers();
        }


        public bool Insert(Publisher item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Publisher item)
        {
            throw new NotImplementedException();
        }

        public Publisher GetItemById(string Id)
        {
            return PublisherStaticData.GetPublisherById(Id);
        }
    }
}
