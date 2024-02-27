
using WebApplicationHelpdeskDomain.Entities.Ticket;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceTicketCreate
{
    public class RegisterTicketService : IRegisterTicketService
    {
        private readonly IRegisterTicketRepository _context;
        public RegisterTicketService(IRegisterTicketRepository context)
        {
            _context = context;
        }
        public async Task Create(TicketCreate ticketCreate)
        {
            await _context.Create(ticketCreate);
        }
    }
}
