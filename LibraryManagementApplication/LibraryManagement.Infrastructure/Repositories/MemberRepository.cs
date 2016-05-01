using LibraryManagement.Domain.Model;
using LibraryManagement.Infrastructure.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class MemberRepository : IRepository<Member>
    {
        //can be inject using DI container
        private IContext<Member> _memberContext = new MemberContext();


        public Member this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Member item)
        {
            _memberContext.Insert(item);
        }

        public IList<Member> FindAll()
        {
           return _memberContext.GetDummyObjects();
        }

        public Member FindBy(Guid key)
        {
           return _memberContext.GetDummyObjects().FirstOrDefault(m => m.EntityIdentityKey == key);
        }

        public void Remove(Member item)
        {
            _memberContext.Delete(item);
        }
    }
}
