﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Clients
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Address { get; set; }
        
        public int PostCode { get; set; }
        
        public int Nip { get; set; }
        
    }
}
