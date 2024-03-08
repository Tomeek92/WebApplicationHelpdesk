using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Queries.HelpdeskUsers.Handler
{
    public class GetRegisterUserHelpdeskQueryHandler : IRequestHandler<GetRegisterUserHelpdeskQuery, HelpdeskUserDto>
    {
        private readonly IRegisterHelpdeskoRepository _repository;
        private readonly IMapper _mapper;
        public GetRegisterUserHelpdeskQueryHandler(IRegisterHelpdeskoRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }
        public async Task<HelpdeskUserDto> Handle(GetRegisterUserHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var detailsUser = await _repository.GetDetailsByUserName(request.UserName);
            var dto = _mapper.Map<HelpdeskUserDto>(detailsUser);
            return dto;
        }
    }
}
