using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class RegisterForClientSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public RegisterForClientSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context; 
        }
        public async Task Seed()
        {
            if(await _context.Database.CanConnectAsync())
            {
                var userName = "Barbara234";
                var existingClient = _context.userRegisterForClients.FirstOrDefault(c => c.UserName==userName);
                if (existingClient == null)
                {
                    var registerForClient = new RegisterForClient()
                    {
                        UserName = userName,
                        UserEmail = "Barbara@wp.pl"
                    };
                    _context.userRegisterForClients.Add(registerForClient);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
