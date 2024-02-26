using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class TicketStatusSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public TicketStatusSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            var ticketStatusName = "status";
            var existingName = _context.ticketStatus.FirstOrDefault(c => c.Status == ticketStatusName);
            if (await _context.Database.CanConnectAsync())
            {
                if (existingName == null)
                {
                    var ticketStatus = new TicketStatus()
                    {
                        Status = ticketStatusName
                    };
                    _context.ticketStatus.Add(ticketStatus);
                    await _context.SaveChangesAsync();
                }
            }
        }
        
    }
}
