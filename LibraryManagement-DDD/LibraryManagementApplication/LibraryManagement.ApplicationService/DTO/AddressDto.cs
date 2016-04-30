﻿using System;

namespace LibraryManagement.ApplicationService.DTO
{
    [Serializable]
    public class AddressDto
    {
        public string Street{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
    }
}