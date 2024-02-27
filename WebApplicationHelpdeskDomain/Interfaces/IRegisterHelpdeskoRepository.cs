using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskDomain.Interfaces
{
    public interface IRegisterHelpdeskoRepository
    {
        Task Create(RegisterForHelpdesk registerForHelpdesk);
    }
}
