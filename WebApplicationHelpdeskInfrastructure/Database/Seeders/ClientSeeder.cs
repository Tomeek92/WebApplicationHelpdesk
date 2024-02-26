using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using WebApplicationHelpdeskDomain.Entities.Clients;

namespace WebApplicationHelpdeskInfrastructure.Database.Seeders
{
    public class ClientSeeder
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public ClientSeeder(WebApplicationHelpdeskDbContext context)
        {

            _context = context;

        }
        public async Task Seed()
        {
            if (await _context.Database.CanConnectAsync())
            {
                var clientName = "Bydgoszcz Południe";
                var existingClient = _context.clients.FirstOrDefault(c => c.Name == clientName);

                if (existingClient == null)
                {
                    var newClient = new Client()
                    {
                        Name = clientName,
                        Address = "Szpitalna 51/2",
                        PostCode = 85828,
                        Nip = 123456
                    };
                }
            }
        }
    }
}
