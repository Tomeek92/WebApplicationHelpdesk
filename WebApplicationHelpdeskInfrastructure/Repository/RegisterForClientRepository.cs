using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database;

namespace WebApplicationHelpdeskInfrastructure.Repository
{
    public class RegisterForClientRepository : IRegisterClientRepository
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public RegisterForClientRepository(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Create(Client client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();  
        }

        public async Task<IEnumerable<Client>> GetAll() => await _context.clients.ToListAsync();

    }
}
