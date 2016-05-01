using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Base
{

    public interface IEntity
    {
        Guid EntityIdentityKey { get; }
        

    }
}