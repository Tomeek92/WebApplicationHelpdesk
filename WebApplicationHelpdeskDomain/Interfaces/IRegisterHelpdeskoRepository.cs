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
        Task<RegisterForHelpdesk?> GetByName(string name);
        Task<IEnumerable<RegisterForHelpdesk>> GetAll();
        Task<RegisterForHelpdesk> GetDetailsByUserName(string userName);
    }
}
