using AutoMapper;
using MediatR;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.ClientUsers.Handler
{
    public class GetAllRegisterClientQueryHandler : IRequestHandler<GetAllRegisterClientQuery, IEnumerable<ClientUserDto>>
    {
        private readonly IRegisterUserForClientRepository _context;
        private readonly IMapper _mapper;
        public GetAllRegisterClientQueryHandler(IRegisterUserForClientRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ClientUserDto>> Handle(GetAllRegisterClientQuery request, CancellationToken cancellationToken)
        {
            var registerForClient = await _context.GetAll();
            var dtos = _mapper.Map<IEnumerable<ClientUserDto>>(registerForClient);

            return dtos;
        }
    }
}
