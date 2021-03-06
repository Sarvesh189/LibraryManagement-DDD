﻿using LibraryManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.DAL
{
    class PublisherStaticData
    {
        private static List<Publisher> PublisherList = new List<Publisher>() { 
             new Publisher() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6341",Name = "Wrox Publication", Email = "cc@wrox.com", WebSite="www.wrox.com", Office = new Address(){Street = "111, Boulevard", City = "Paris", State = "Paris", ZipCode = "75002", Country = "France" }, BookIds = new List<string>(){ "2E2601B0-2259-494A-949E-F73C3BFF6381", "2E2601B0-2259-494A-949E-F73C3BFF6382" } },
             new Publisher() {Id = "2E2601B0-2259-494A-949E-F73C3BFF6342", Name = "MacMillan Publication", Email = "cc@mm.com", WebSite="www.macmillan.com", Office = new Address(){ Street = "101, Boulevard", City = "Paris", State = "Paris", ZipCode = "75002", Country = "France" } , BookIds = new List<string>() { "2E2601B0-2259-494A-949E-F73C3BFF6383", "2E2601B0-2259-494A-949E-F73C3BFF6384" } },
             new Publisher() { Id = "2E2601B0-2259-494A-949E-F73C3BFF6343",Name = "Max Publication", Email = "cc@max.com", WebSite="www.max.com", Office = new Address(){Street = "151, Boulevard", City = "Paris", State = "Paris", ZipCode ="75002", Country = "France" }, BookIds = new List<string>() },
             new Publisher() { Id = "2E2601B0-2259-494A-949E-F73C3BFF6345",Name = "Orielly Publication", Email = "cc@orielly.com", WebSite="www.orielly.com", Office = new Address(){Street = "201, Boulevard", City = "Paris", State = "Paris",ZipCode = "75002", Country = "France" }, BookIds = new List<string>() }
        };

        public static List<Publisher> GetPublishers()
        {
             PublisherList.OrderBy(pub=>pub.Name);
            return PublisherList;
        }

        public static Publisher GetPublisherById(string Id)
        {
            return PublisherList.FirstOrDefault(pb => pb.Id.ToUpper() == Id.ToUpper());
        }
        public static void Remove(string Id)
        {
           var pub = PublisherList.FirstOrDefault(pb => pb.Id.ToUpper() == Id.ToUpper());
            PublisherList.Remove(pub);
        }

        public static void Add(Publisher pub)
        {
            PublisherList.Add(pub);
        }
    }
}
