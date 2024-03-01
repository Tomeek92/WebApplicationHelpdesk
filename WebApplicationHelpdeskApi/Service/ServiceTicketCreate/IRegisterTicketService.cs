using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskApi.Service.ServiceTicketCreate
{
    public interface IRegisterTicketService
    {
        Task Create(TicketCreateDto ticketCreate);
        Task<IEnumerable<TicketCreateDto>> GetAll();
    }
}