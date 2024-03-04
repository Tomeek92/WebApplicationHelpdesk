using Microsoft.EntityFrameworkCore;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database;

namespace WebApplicationHelpdeskInfrastructure.Repository
{
    public class RegisterUsersForClientRepository : IRegisterUserForClientRepository
    {
        private readonly WebApplicationHelpdeskDbContext _context;

        public RegisterUsersForClientRepository(WebApplicationHelpdeskDbContext context)
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
