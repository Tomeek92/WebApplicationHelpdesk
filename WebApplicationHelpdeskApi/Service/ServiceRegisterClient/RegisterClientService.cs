using AutoMapper;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterClient
{
    public class RegisterClientService : IRegisterClientService
    {
        private readonly IRegisterClientRepository _context;
        private readonly IMapper _mapper;
        public RegisterClientService(IRegisterClientRepository context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Create(ClientUserDto registerForClientDto)
        {
          var registerClient = _mapper.Map<RegisterForClient>(registerForClientDto);

           await _context.Create(registerClient);
        }

        public async Task<IEnumerable<ClientUserDto>> GetAll()
        {
            var registerForClient = await _context.GetAll();
            var dtos = _mapper.Map<IEnumerable<ClientUserDto>>(registerForClient);

            return dtos;
        }
    }
}
