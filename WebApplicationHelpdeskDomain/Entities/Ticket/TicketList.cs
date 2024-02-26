using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskDomain.Entities.Ticket
{
    public class TicketList
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string TicketType { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string Priority { get; set; } = default!;
    }
}
