using AutoMapper;
using MediatR;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.HelpdeskUsers.Handler
{
    public class CreateHelpdeskUserCommandHandler : IRequestHandler<CreateHelpdeskUserCommand>
    {
        private readonly IRegisterHelpdeskoRepository _context;
        private readonly IMapper _mapper;
        public CreateHelpdeskUserCommandHandler(IRegisterHelpdeskoRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateHelpdeskUserCommand request, CancellationToken cancellationToken)
        {
            var registerHelpdesk = _mapper.Map<RegisterForHelpdesk>(request);
            await _context.Create(registerHelpdesk);
            return Unit.Value;
        }
     
        
       
    
    }
}
