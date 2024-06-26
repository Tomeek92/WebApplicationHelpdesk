﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskDomain.Interfaces
{
    public interface IRegisterClientRepository
    {
        Task Create(Client client);
        Task<IEnumerable<WebApplicationHelpdeskDomain.Entities.Clients.Client>> GetAll();
    }
}
