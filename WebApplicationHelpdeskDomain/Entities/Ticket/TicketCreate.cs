
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationHelpdeskDomain.Entities.Ticket
{
    public class TicketCreate
    {
        [Key]
        public Guid Id { get; set; }
    
        public string Title { get; set; } = null!;
        
        public string Description { get; set; } = null!;
        
        public DateTime StartTime { get; set; }
        public TicketStatus Status { get; set; } = default!;
        public DateTime CloseTime { get; set; }
    }
}
