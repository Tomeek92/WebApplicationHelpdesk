using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Command.HelpdeskUsers.Handler
{
    public class CreateHelpdeskUserCommandHandler : IRequestHandler<CreateHelpdeskUserCommand>
    {
        private readonly IRegisterHelpdeskoRepository _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        public CreateHelpdeskUserCommandHandler(IRegisterHelpdeskoRepository context, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<Unit> Handle(CreateHelpdeskUserCommand request, CancellationToken cancellationToken)
        {
            var user = new IdentityUser
            {
                UserName = request.UserName,
                Email = request.UserEmail
            };
            var result = await _userManager.CreateAsync(user,request.UserPassword);
            var registerHelpdesk = _mapper.Map<RegisterForHelpdesk>(request);
            await _context.Create(registerHelpdesk);
            return Unit.Value;
        }
     
        
       
    
    }
}
