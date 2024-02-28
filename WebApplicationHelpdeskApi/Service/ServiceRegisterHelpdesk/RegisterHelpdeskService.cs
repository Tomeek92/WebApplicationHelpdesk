using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterHelpdesk
{
    public class RegisterHelpdeskService : IRegisterHelpdeskService
    {
        private readonly IRegisterHelpdeskoRepository _context;
        private readonly IMapper _mapper;
        public RegisterHelpdeskService(IRegisterHelpdeskoRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Create(HelpdeskUserDto registerForHelpdeskDto)
        {
            var registerHelpdesk = _mapper.Map<RegisterForHelpdesk>(registerForHelpdeskDto);
            await _context.Create(registerHelpdesk);
        }
    }
}
