using System;

namespace LibraryManagement.Domain.Base
{
    public interface IDomainEvent
    {
        Guid EventId { get;}
    }
}