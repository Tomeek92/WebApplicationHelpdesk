using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Ticket
{
    public class TicketStatus
    {
        [Key]
        public Guid Id {  get; set; }
        public string? Status { get; set; }
      
        
      
    }
}
