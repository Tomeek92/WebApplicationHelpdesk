using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Ticket
{
    public class TicketType
    {
        [Key]
        public Guid Id { get; set; } 
        public string TicketTypee { get; set; } = default!;
       
    }
}
