using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class TicketPrioritySeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public TicketPrioritySeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            var priorityName = "Priorytet";
            var existingName = _context.ticketPriority.FirstOrDefault(c => c.Priority == priorityName);
            if (await _context.Database.CanConnectAsync())
            {
                if (existingName == null)
                {

                    var newTicketPriority = new TicketPriority()
                    {
                        Priority = priorityName
                    };
                    _context.ticketPriority.Add(newTicketPriority);
                    await _context.SaveChangesAsync();
                }
                
            }
        }
    }
}
