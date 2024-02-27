
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskDomain.Interfaces
{
    public interface IRegisterTicketRepository
    {
        Task Create(TicketCreate ticketCreate);
    }
}
