using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterHelpdesk
{
    public class RegisterHelpdeskService : IRegisterHelpdeskService
    {
        private readonly IRegisterHelpdeskoRepository _context;
        public RegisterHelpdeskService(IRegisterHelpdeskoRepository context)
        {
            _context = context;
        }
        public async Task Create(RegisterForHelpdesk registerForHelpdesk)
        {
            await _context.Create(registerForHelpdesk);
        }
    }
}
