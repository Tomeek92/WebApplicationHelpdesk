using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.Clients.Handler
{
    public class GetAllRegisterClientsQueryHandler : IRequestHandler<GetAllRegisterClientsQuery,IEnumerable<ClientDto>>
    {
        private readonly IRegisterClientRepository _context;
        private readonly IMapper _mapper;
        public GetAllRegisterClientsQueryHandler(IRegisterClientRepository context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDto>> Handle(GetAllRegisterClientsQuery request, CancellationToken cancellationToken)
        {
            var clientRegister = await _context.GetAll();
            var dtos = _mapper.Map<IEnumerable<ClientDto>>(clientRegister);

            return dtos;
        }
    }
}
