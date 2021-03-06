﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Base.RepositoryContract
{
    public interface IRepository<T> where T : IAggregate
    {
        T FindBy(Guid key);
        IList<T> FindAll();
        void Add(T item);
        //T this[object key] { get; set; }
        void Remove(T item);

        void Update(T item);
    }
}
