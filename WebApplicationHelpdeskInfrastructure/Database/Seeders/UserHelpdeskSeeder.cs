using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Helpdesk;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class UserHelpdeskSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public UserHelpdeskSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context; 
        }
        public async Task Seed()
        {
            var userHelpdeskName = "Ferdynand";
            var existingUserName = _context.userHelpdesks.FirstOrDefault(c => c.Name==userHelpdeskName);

            if(await _context.Database.CanConnectAsync())
            {
                if (existingUserName == null)
                {
                    var userHelpdesk = new UsersHelpdesk()
                    {
                        Name = userHelpdeskName,
                        Email = "ferdynand@wp.pl"
                    };
                    _context.userHelpdesks.Add(userHelpdesk);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
