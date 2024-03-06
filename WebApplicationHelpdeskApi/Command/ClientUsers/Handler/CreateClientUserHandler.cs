using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.ClientUsers.Handler
{
    public class CreateClientUserHandler : IRequestHandler<CreateClientUserCommand>
    {
        private readonly IRegisterUserForClientRepository _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        public CreateClientUserHandler(IRegisterUserForClientRepository context, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<Unit> Handle(CreateClientUserCommand request, CancellationToken cancellationToken)
        {
            var user = new IdentityUser
            {
                UserName = request.UserName,
                Email = request.UserEmail
            };
            var result = await _userManager.CreateAsync(user, request.UserPassword);
            var registerClient = _mapper.Map<RegisterForClient>(request);

            await _context.Create(registerClient);

            return Unit.Value;


        }
    }
}
