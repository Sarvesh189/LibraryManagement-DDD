using System;

namespace LibraryManagement.Domain.Base
{
    public interface IEvent
    {
        Guid EventId { get;}

        DateTime PublishedOn { get;}
    }
}