using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ApplicationService.BookService
{
    [Serializable]
    public class BookDto
    {
        public Guid BookId
        { get; set; }

        public string Title
        {
            get;
            set;
        }

        public string ISBN
        {
            get; set;
        }

        public PublisherDto Publisher
        {
            get; set;
        }

        public IReadOnlyList<AuthorDto> Authors { get; set; }

        public string Language
        {
            get; set;
        }      

        public decimal Price { get; set; }
    }
}
