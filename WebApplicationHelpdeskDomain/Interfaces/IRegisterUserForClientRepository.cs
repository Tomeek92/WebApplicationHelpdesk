using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskDomain.Interfaces
{
    public interface IRegisterUserForClientRepository
    {
        Task Create(RegisterForClient registerForClient);
        Task<RegisterForClient?> GetByName(string name);
        Task<IEnumerable<RegisterForClient>> GetAll();
        Task<RegisterForClient> GetDetailsByUserName(string userName);
    }
}
