﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AddContactRequest
    {   
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? City { get; set; }
            public string? Mail { get; set; }
            public string? Phone { get; set; }
        
    }
}
