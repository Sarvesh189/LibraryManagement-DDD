using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Infrastructure.DAL
{
    public class MemberContext : IContext<Member>
    {
        private List<Member> _members = new List<Member>();
        public bool Delete(Member member)
        {
            var targetmember = _members.FirstOrDefault(m => m.EntityIdentityKey == member.EntityIdentityKey);
            if (targetmember == null) throw new Exception("member does not exist");
            _members.Remove(member);
            return true;
        }

        public List<Member> GetDummyObjects()
        {
            _members.Add(new Member(Guid.NewGuid()) {
                FirstName = "Steve",
                LastName = "Smith",
                Address = new Address("18 canal stree", "Dublin", "IreLandProvice1", "560100"),
                Age = 32
            });
            _members.Add(new Member(Guid.NewGuid())
            {
                FirstName = "Martin",
                LastName = "GoldSmith",
                Address = new Address("18 canal stree", "Dublin", "IreLandProvice1", "560100"),
                Age = 34
            });
            _members.Add(new Member(Guid.NewGuid())
            {
                FirstName = "Rami",
                LastName = "Waugh",
                Address = new Address("19 canal stree", "Dublin", "IreLandProvice1", "560100"),
                Age = 65
            });
            _members.Add(new Member(Guid.NewGuid())
            {
                FirstName = "Stefen",
                LastName = "Hawkin",
                Address = new Address("20 canal stree", "Dublin", "IreLandProvice1", "560100"),
                Age = 35
            });
            return _members;
        }

        public bool Insert(Member member)
        {
            this._members.Add(member);
            return true;
        }

        public bool Update(Member member)
        {
            var targetmember = this._members.FirstOrDefault(m => m.EntityIdentityKey == member.EntityIdentityKey);
            if (targetmember == null)
                throw new Exception("member does not exist");
            targetmember = member;
            return true;
        }
    }
}
