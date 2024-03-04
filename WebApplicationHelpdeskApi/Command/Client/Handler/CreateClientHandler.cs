using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;


namespace WebApplicationHelpdeskApi.Command.Client.Handler
{
    public class CreateClientHandler : IRequestHandler<CreateClientCommand>
    {
        private readonly IRegisterClientRepository _context;
        private readonly IMapper _mapper;
        public CreateClientHandler(IRegisterClientRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var registerClient = _mapper.Map<WebApplicationHelpdeskDomain.Entities.Clients.Client>(request);

            await _context.Create(registerClient);

            return Unit.Value;
        }
    }
}
