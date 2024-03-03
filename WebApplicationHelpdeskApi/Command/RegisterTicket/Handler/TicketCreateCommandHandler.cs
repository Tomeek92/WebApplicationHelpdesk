using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Ticket;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.RegisterTicket.Handler
{
    public class TicketCreateCommandHandler : IRequestHandler<TicketCreateCommand>
    {
        private readonly IRegisterTicketRepository _context;
        private readonly IMapper _mapper;
        public TicketCreateCommandHandler(IRegisterTicketRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(TicketCreateCommand request, CancellationToken cancellationToken)
        {
            var ticketCreate = _mapper.Map<TicketCreate>(request);
            await _context.Create(ticketCreate);
            return Unit.Value;
        }
    }
}
