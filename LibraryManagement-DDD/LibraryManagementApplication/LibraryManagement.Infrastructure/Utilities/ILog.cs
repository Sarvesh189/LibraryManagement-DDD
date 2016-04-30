using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Utilities
{
   public interface ILog
    {
        void LogMessage(string message);
    }
    public class Log : ILog
    {
        public void LogMessage(string message)
        {
           var strwriter = File.AppendText("D:\\LibraryManagement.txt");
            strwriter.WriteLine(message);
            strwriter.Dispose();
        }
    }

    public class LogHandler
    {
        public static void HandleBookCreatedEvent(BookCreatedEvent domainevent)
        {
            var newbookevent = (BookCreatedEvent)domainevent;

            var log = new Log();
            //log.LogMessage("------------------New book created-----------------");
            log.LogMessage(string.Format("Book purchased and its details are EventId: {0} | ISBN:{1} | Title:{2} | Price:{3} ", newbookevent.EventId, newbookevent.NewBook.ISBN, newbookevent.NewBook.Title, newbookevent.NewBook.Price));
        }

        public static void HandleBookDeletedEvent(BookDeletedEvent domainevent)
        {
            var deletedbookevent = (BookDeletedEvent)domainevent;

            var log = new Log();
          
            log.LogMessage(string.Format(" Book with the detail is removed EventId: {0} | ISBN:{1} | Title:{2} | Price:{3} ", deletedbookevent.EventId, deletedbookevent.DeletedBook.ISBN, deletedbookevent.DeletedBook.Title, deletedbookevent.DeletedBook.Price));
        }
    }


}
