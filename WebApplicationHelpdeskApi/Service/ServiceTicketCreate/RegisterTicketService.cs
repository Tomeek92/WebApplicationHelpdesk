
using AutoMapper;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Ticket;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceTicketCreate
{
    public class RegisterTicketService : IRegisterTicketService
    {
        private readonly IRegisterTicketRepository _context;
        private readonly IMapper _mapper;
        public RegisterTicketService(IRegisterTicketRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }
        public async Task Create(TicketCreateDto ticketCreateDto)
        {
            var ticketCreate = _mapper.Map<TicketCreate>(ticketCreateDto);
            await _context.Create(ticketCreate);
        }
    }
}
