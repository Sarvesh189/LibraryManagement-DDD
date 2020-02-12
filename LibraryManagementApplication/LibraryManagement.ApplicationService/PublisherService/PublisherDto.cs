using System;
using System.Collections.Generic;

namespace LibraryManagement.ApplicationService.PublisherService
{
    public sealed class PublisherDto
    {
        public Guid Id
        { get; set; }
        public string Name { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public string OfficeAddress { get; set; }

        public IList<BookDto> Books { get; set; }

    }
}