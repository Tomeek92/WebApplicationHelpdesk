using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Clients
{
    public class UsersClient
    {
        [Key]
        public Guid Id { get; set; }
      
        public string Name { get; set; } = null!;
        
        public string Email { get; set; } = null!;
    }
}
