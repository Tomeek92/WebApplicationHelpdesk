using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class RegisterForHelpdeskSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public RegisterForHelpdeskSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            var registerName = "Tadeusz321";
            var existingUsername = _context.userRegisterForHelpdesks.FirstOrDefault(c => c.UserName==registerName);  
            
            if (await _context.Database.CanConnectAsync())
            {
                if (existingUsername == null)
                {


                    var registerForHelpdesk = new RegisterForHelpdesk()
                    {
                        UserName = registerName,
                        UserEmail = "tadeusz321@wp.pl"
                    };
                    _context.userRegisterForHelpdesks.Add(registerForHelpdesk);
                    await _context.SaveChangesAsync();
                }
            }
            
        }
    }
}
