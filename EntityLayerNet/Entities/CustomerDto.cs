using System.Collections.Generic;
using System;


namespace EntityLayer.Entities
{
    public class CustomerDto
    {
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
    }
}
