//using LibraryManagement.Domain.Base;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace LibraryManagement.Domain.Model
//{
//    public class Member : EntityBase<Member>, IAggregate
//    {
//        private string _firstName;
//        private string _middleName;
//        private string _lastName;
//        private Address _address;
//        private int _age;
//        private List<Book> _bookList;

//        public Member(Guid membershipId) : base(membershipId)
//        {
//            _bookList = new List<Book>();
//        }


//        public string MiddleName
//        {
//            get
//            {
//                return _middleName;
//            }

//            set
//            {
//                _middleName = value;
//            }
//        }

//        public string LastName
//        {
//            get
//            {
//                return _lastName;
//            }

//            set
//            {
//                _lastName = value;
//            }
//        }

//        public Address Address
//        {
//            get
//            {
//                return _address;
//            }

//            set
//            {
//                _address = value;
//            }
//        }

//        public List<Book> BookList
//        {
//            get
//            {
//                return _bookList;
//            }

//            set
//            {
//                _bookList = value;
//            }
//        }

//        public string FullName
//        {
//            get
//            {
//                return string.Format("{0} {1} {2}", this._firstName, this._middleName, this._lastName);
//            }
//        }

//        public int Age
//        {
//            get
//            {
//                return _age;
//            }

//            set
//            {
//                _age = value;
//            }
//        }

//        public string FirstName
//        {
//            get
//            {
//                return _firstName;
//            }

//            set
//            {
//                _firstName = value;
//            }
//        }

//        public Member CreateMember(Member member)
//        {
//            var newMember = new Member(Guid.NewGuid());
//            newMember = member;
//            member.Validate();

//            return newMember;

//        }
               
//        protected override void Validate()
//        {
//            if (this._age < 18 || this._age > 100)
//                throw new Exception("Age of the member should be more than 18 yrs and less than 100 yrs.");
//            if (this._address == null)
//                throw new Exception("There should be valid member address");
//            if (string.IsNullOrWhiteSpace(this._firstName))
//                throw new Exception( "Member first name can not be null or empty");
//            if (string.IsNullOrWhiteSpace(this._lastName))
//                throw new Exception("Member last name is invalid"); 
//        }
//    }
//}