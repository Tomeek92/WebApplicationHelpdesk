using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Clients;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    
    public class UserClientSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public UserClientSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            var userClientName = "Andrzej123";
            var existingUserClientName = _context.usersClients.FirstOrDefault(c => c.Name==userClientName);
            if(await _context.Database.CanConnectAsync())
            {
                if (existingUserClientName == null)
                { 
                    var newUserClient = new UsersClient()
                    {
                        Name = userClientName,
                        Email = "Andrzej@bydgoszcz.pl"
                    };
                    _context.usersClients.Add(newUserClient);
                    await _context.SaveChangesAsync();
                }
            }
        }

    }
}
