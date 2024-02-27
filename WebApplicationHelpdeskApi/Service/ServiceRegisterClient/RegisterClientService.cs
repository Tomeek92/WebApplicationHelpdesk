using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterClient
{
    public class RegisterClientService : IRegisterClientService
    {
        private readonly IRegisterClientRepository _context;
        public RegisterClientService(IRegisterClientRepository context )
        {
            _context = context;
        }
        public async Task Create(RegisterForClient registerForClient)
        {
           await _context.Create(registerForClient);
        }
    }
}
