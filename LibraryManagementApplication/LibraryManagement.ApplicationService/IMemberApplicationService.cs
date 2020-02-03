//using LibraryManagement.ApplicationService.DTO;
//using LibraryManagement.ApplicationService.Mapping;
//using LibraryManagement.Domain.Model;
//using LibraryManagement.Infrastructure.Repositories;
//using System;
//using System.Collections.Generic;

//using System.Linq;
//using System.Text;

//namespace LibraryManagement.ApplicationService
//{
//  public  interface IMemberApplicationService
//    {
//        void AddMember(MemberDto member);

//        void RemoveMember(MemberDto member);

//        void UpdateMember(MemberDto member);

//        IList<Member> GetMembers();
//        Member GetMemberById(Guid memberId);
//    }

//    public class MemberApplicationService : IMemberApplicationService
//    {
//        //can be injected
//        private MemberRepository _memberRep = new MemberRepository();

//        public void AddMember(MemberDto member)
//        {
//           var cormember =  MappingConfiguration.MapMemberDtoToMember(member);
//           _memberRep.Add(cormember);
//        }

//        public Member GetMemberById(Guid memberId)
//        {
//            throw new NotImplementedException();
//        }

//        public IList<Member> GetMembers()
//        {
//           return _memberRep.FindAll();
//        }

//        public void RemoveMember(MemberDto member)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateMember(MemberDto member)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
