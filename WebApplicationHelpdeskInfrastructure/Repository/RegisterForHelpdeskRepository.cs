
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database;

namespace WebApplicationHelpdeskInfrastructure.Repository
{
    public class RegisterForHelpdeskRepository : IRegisterHelpdeskoRepository
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public RegisterForHelpdeskRepository(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Create(RegisterForHelpdesk registerForHelpdesk)
        {
            _context.Add(registerForHelpdesk);
            await _context.SaveChangesAsync();
        }
    }
}
