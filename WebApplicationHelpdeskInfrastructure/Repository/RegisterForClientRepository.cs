using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task Create(RegisterForClient registerForClient)
        {
            _context.Add(registerForClient);
           await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RegisterForClient>> GetAll() 
            => await _context.userRegisterForClients.ToListAsync();
        
            
   
        public async Task<RegisterForClient?> GetByName(string name)
       => await _context.userRegisterForClients.FirstOrDefaultAsync(cw=>cw.UserName.ToLower()==name.ToLower());
    }
}
