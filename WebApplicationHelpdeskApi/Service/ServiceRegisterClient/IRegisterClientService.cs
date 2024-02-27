using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterClient
{
    public interface IRegisterClientService
    {
        Task Create(RegisterForClient registerForClient);
    }
}
