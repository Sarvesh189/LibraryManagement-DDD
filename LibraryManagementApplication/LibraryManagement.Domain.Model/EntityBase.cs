using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model
{
    public abstract class EntityBase<T> : IEntity, IEquatable<T> 
    {
        private Guid _entityIdentityKey;

        private List<EventBase> _eventList;

       

        protected EntityBase(Guid entityIdentityKey)
        {
           
            _entityIdentityKey = entityIdentityKey;
            _eventList = new List<EventBase>();
           
        }


        public Guid EntityIdentityKey
        {
            get
            {
                return _entityIdentityKey;
            }
            protected set
            {
                if (value == null)
                    throw new ArgumentNullException("EntityIdentityKey", "EntityIdentityKey can not be null");
                _entityIdentityKey = value;
            }
        }

        public ReadOnlyCollection<EventBase> EventList
        {
            get { return _eventList.AsReadOnly(); }
        }

        protected void RaiseEvent(EventBase domainEvent)
        {
            _eventList.Add(domainEvent);
        }

        public void RemoveEvent(EventBase domainEvent)
        {
            _eventList.Remove(domainEvent);
        }

        public void ClearEvent()
        {
            _eventList.Clear();
        }

        #region model Validation 
        protected abstract void Validate();

       

        #endregion
       
        #region comparing, equality
        public bool Equals(T entity)
        {
            return
                entity != null
                && entity is EntityBase<T>
                && this.Equals((object)entity);
        }

        //public override bool Equals(object entity)
        //{
        //  return  entity != null
        //       && entity is EntityBase<T>
        //       && this.Equals((object)entity);
        //}
        public static bool operator ==(EntityBase<T> firstEntity, EntityBase<T> secondEntity)
        {
            if ((object)firstEntity == null && (object)secondEntity == null)
            {
                return true;
            }
            if ((object)firstEntity == null || (object)secondEntity == null)
            {
                return false;
            }
            if (!firstEntity.EntityIdentityKey.Equals(secondEntity.EntityIdentityKey))
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(EntityBase<T> firstEntity, EntityBase<T> secondEntity)
        {
            return !(firstEntity.Equals(secondEntity)) ;
        }
        #endregion


        public override int GetHashCode()
        {
            if (this._entityIdentityKey != null)
            {
                return this._entityIdentityKey.GetHashCode();
            }
            else
                return 0;
        }
    }
}
