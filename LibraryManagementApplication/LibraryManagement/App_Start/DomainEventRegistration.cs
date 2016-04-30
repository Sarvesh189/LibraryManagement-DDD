using LibraryManagement.Domain.Model;
using LibraryManagement.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.App_Start
{
    public class DomainEventRegistration
    {
        public static void RegisterAction()
        {
            DomainEventManager.RegisterAction<BookCreatedEvent>(LogHandler.HandleBookCreatedEvent);
            DomainEventManager.RegisterAction<BookDeletedEvent>(LogHandler.HandleBookDeletedEvent);
        }
    }
}