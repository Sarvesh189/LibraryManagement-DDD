﻿using LibraryManagement.Domain.Model.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
    public interface IContext<T>
    {
        List<T> GetItems();

        T GetItemById(string Id);
        bool Update(T item);
        bool Delete(string Id);
        bool Insert(T item);
        
    }

    
}
