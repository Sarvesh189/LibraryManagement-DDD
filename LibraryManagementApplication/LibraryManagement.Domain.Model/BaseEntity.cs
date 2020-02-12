using LibraryManagement.Domain.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace LibraryManagement.Domain.Model
{
    public abstract class BaseEntity<T> : IEntity 
    {
        private Guid _entityIdentityKey;

        private List<BaseDomainEvent> _eventList;

        protected BaseEntity(Guid entityIdentityKey)
        {
           
            _entityIdentityKey = entityIdentityKey;
            _eventList = new List<BaseDomainEvent>();
           
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

        //#region DomainEvent
        //public ReadOnlyCollection<BaseDomainEvent> EventList
        //{
        //    get { return _eventList.AsReadOnly(); }
        //}

        //protected void RaiseEvent(BaseDomainEvent domainEvent)
        //{
        //    _eventList.Add(domainEvent);
        //}

        //public void RemoveEvent(BaseDomainEvent domainEvent)
        //{
        //    _eventList.Remove(domainEvent);
        //}

        //public void ClearEvent()
        //{
        //    _eventList.Clear();
        //}
        // #endregion

        #region Model Validation 
        protected abstract void Validate();

        #endregion
       
        #region comparing, equality
        //public bool Equals(T entity)
        //{
        //    return
        //        entity != null
        //        && entity is BaseEntity<T>
        //        && this.Equals((object)entity);
        //}

        public override bool Equals(object entity)
        {
            return entity != null
                 && entity is BaseEntity<T>
                 && this.Equals((object)entity);
        }
        public static bool operator == (BaseEntity<T> firstEntity, BaseEntity<T> secondEntity)
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

        public static bool operator !=(BaseEntity<T> firstEntity, BaseEntity<T> secondEntity)
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
