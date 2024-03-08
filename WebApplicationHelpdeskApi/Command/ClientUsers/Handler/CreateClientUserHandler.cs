using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using WebApplicationHelpdesk.OnlineUsers;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.ClientUsers.Handler
{
    public class CreateClientUserHandler : IRequestHandler<CreateClientUserCommand>
    {
        private readonly IRegisterUserForClientRepository _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserContext _userContext;
        public CreateClientUserHandler(IRegisterUserForClientRepository context, IMapper mapper, UserManager<IdentityUser> userManager,IUserContext userContext)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _userContext = userContext;
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

            registerClient.CreateById = _userContext.GetOnlineUser().Id;

            await _context.Create(registerClient);

            return Unit.Value;


        }
    }
}
