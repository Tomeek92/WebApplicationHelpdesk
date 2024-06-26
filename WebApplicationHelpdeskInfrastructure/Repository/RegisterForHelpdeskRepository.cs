﻿
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<RegisterForHelpdesk>> GetAll() 
            => await _context.userRegisterForHelpdesks.ToListAsync();
       

        public async Task<RegisterForHelpdesk?> GetByName(string nameEmail)
            => await _context.userRegisterForHelpdesks.FirstOrDefaultAsync(cw => cw.UserEmail.ToLower() == nameEmail.ToLower());

        public async Task<RegisterForHelpdesk> GetDetailsByUserName(string userName)
            => await _context.userRegisterForHelpdesks.FirstOrDefaultAsync(c => c.UserName == userName);
        
            
        
    }
}
