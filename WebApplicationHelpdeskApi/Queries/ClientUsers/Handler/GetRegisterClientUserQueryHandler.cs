using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.ClientUsers.Handler
{
    public class GetRegisterClientUserQueryHandler : IRequestHandler<GetRegisterClientUserQuery, ClientUserDto>
    {
        private readonly IRegisterUserForClientRepository _repository;
        private readonly IMapper _mapper;
        public GetRegisterClientUserQueryHandler(IRegisterUserForClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ClientUserDto> Handle(GetRegisterClientUserQuery request, CancellationToken cancellationToken)
        {
            var detailsUser = await _repository.GetDetailsByUserName(request.UserName);
            var dto = _mapper.Map<ClientUserDto>(detailsUser);
            return dto;
        }
    }
}
