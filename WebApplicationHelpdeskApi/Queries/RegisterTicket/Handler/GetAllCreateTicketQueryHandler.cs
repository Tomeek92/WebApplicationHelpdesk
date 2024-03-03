using AutoMapper;
using MediatR;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.RegisterTicket.Handler
{
    public class GetAllCreateTicketQueryHandler : IRequestHandler<GetAllCreateTicketQuery, IEnumerable<TicketCreateDto>>
    {
        private readonly IRegisterTicketRepository _context;
        private readonly IMapper _mapper;
        public GetAllCreateTicketQueryHandler(IRegisterTicketRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TicketCreateDto>> Handle(GetAllCreateTicketQuery request, CancellationToken cancellationToken)
        {
            var ticketCreate = await _context.GetAll();
            var dto = _mapper.Map<IEnumerable<TicketCreateDto>>(ticketCreate);

            return dto;
        }
    }
}
