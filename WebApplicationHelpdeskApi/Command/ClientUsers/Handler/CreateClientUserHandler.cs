using AutoMapper;
using MediatR;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.ClientUsers.Handler
{
    public class CreateClientUserHandler : IRequestHandler<CreateClientUserCommand>
    {
        private readonly IRegisterUserForClientRepository _context;
        private readonly IMapper _mapper;
        public CreateClientUserHandler(IRegisterUserForClientRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateClientUserCommand request, CancellationToken cancellationToken)
        {

            var registerClient = _mapper.Map<RegisterForClient>(request);

            await _context.Create(registerClient);

            return Unit.Value;


        }
    }
}
