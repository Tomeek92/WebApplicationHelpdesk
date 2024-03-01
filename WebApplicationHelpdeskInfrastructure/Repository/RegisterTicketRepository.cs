using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Ticket;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database;

namespace WebApplicationHelpdeskInfrastructure.Repository
{
    public class RegisterTicketRepository : IRegisterTicketRepository
    {
        private readonly WebApplicationHelpdeskDbContext _context;
        public RegisterTicketRepository(WebApplicationHelpdeskDbContext context)
        {
            _context = context;
        }
        public async Task Create(TicketCreate ticketCreate)
        {
            _context.Add(ticketCreate);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TicketCreate>> GetAll()
            => await _context.ticketCreates.ToListAsync();
       

        public async Task<TicketCreate?> GetByName(string name)
        
        =>   await _context.ticketCreates.FirstOrDefaultAsync(cw => cw.Title.ToLower() == name.ToLower());
        
    }
}
