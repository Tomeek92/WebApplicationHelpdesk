
using System.ComponentModel.DataAnnotations;


namespace WebApplicationHelpdeskDomain.Entities.Ticket
{
    public class TicketCreate
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public TicketStatus Status { get; set; } = default!;
        public DateTime CloseTime { get; set; }
        public TicketType TicketTypee { get; set; } = default!;
    }
}
