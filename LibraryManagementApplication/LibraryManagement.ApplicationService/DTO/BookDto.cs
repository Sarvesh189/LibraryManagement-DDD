using System;

namespace LibraryManagement.ApplicationService.DTO
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
            get;set;
        }

        public string Publisher
        {
            get; set;
        }

        public string Language
        {
            get; set;
        }

        public int Paperback
        {
            get; set;
        }

        public decimal Price { get; set; }
    }
}