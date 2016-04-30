using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.ApplicationService.DTO
{
    [Serializable]
    public class MemberDto
    {
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        public AddressDto Address { get; set; }
        public int Age { get; set; }
        private List<BookDto> BookList { get; set; }
    }
}
