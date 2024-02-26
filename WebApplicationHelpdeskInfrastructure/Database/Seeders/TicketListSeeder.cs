
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class TicketListSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public TicketListSeeder(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            var titleName = "Nagłowek";
            var existingTitle = _context.ticketLists.FirstOrDefault(c => c.Title==titleName);
            if(await _context.Database.CanConnectAsync())
            {
                if (existingTitle == null)
                {
                    var newTicketList = new TicketList()
                    {
                        Title = titleName,
                        Description = "Opis",
                        TicketType = "Typ",
                        Status = "Status",
                        Priority = "Priorytet"

                    };
                    _context.ticketLists.Add(newTicketList);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
