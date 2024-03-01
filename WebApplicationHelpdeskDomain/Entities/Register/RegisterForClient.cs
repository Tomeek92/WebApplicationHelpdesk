﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Register
{
    public class RegisterForClient
    {
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;
        
        public string UserEmail { get; set; } = null!;
    }
}
