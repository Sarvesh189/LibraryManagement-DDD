using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
    public interface IContext<T>
    {
        List<T> GetDummyObjects();
        bool Update(T dummyObject);
        bool Delete(T dummyObject);
        bool Insert(T dummyObject);
    }

    
}
