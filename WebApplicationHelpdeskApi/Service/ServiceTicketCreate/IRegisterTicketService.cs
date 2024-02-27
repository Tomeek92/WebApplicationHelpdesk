using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskApi.Service.ServiceTicketCreate
{
    public interface IRegisterTicketService
    {
        Task Create(TicketCreate ticketCreate);
    }
}