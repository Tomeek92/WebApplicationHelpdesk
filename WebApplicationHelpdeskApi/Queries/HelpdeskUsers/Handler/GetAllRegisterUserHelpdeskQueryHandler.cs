using AutoMapper;
using MediatR;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.HelpdeskUsers.Handler
{
    public class GetAllRegisterUserHelpdeskQueryHandler : IRequestHandler<GetAllRegisterUserHelpdeskQuery, IEnumerable<HelpdeskUserDto>>
    {
        private readonly IRegisterHelpdeskoRepository _context;
        private readonly IMapper _mapper;
        public GetAllRegisterUserHelpdeskQueryHandler(IRegisterHelpdeskoRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<HelpdeskUserDto>> Handle(GetAllRegisterUserHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var userHelpdesk = await _context.GetAll();
            var dtos = _mapper.Map<IEnumerable<HelpdeskUserDto>>(userHelpdesk);
            return dtos;
        }
    }
}
