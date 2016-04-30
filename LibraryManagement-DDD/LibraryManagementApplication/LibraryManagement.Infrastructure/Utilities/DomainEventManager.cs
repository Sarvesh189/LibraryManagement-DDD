using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Utilities
{
   public class DomainEventManager
    {
        private static List<Delegate> actions;
        public static void RegisterAction<T>(Action<T> action)
        {
            if (actions == null)
                actions = new List<Delegate>();
            actions.Add(action);
        }
        public static void Publish<T>(T domaineventobject)
        {
            try
            {
                if (actions != null)
                {
                    var action = actions.FirstOrDefault(a => a.Method.GetParameters()[0].ParameterType == typeof(T));
                    if(action != null)
                    ((Action<T>)action)(domaineventobject);
               }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
    }
}
