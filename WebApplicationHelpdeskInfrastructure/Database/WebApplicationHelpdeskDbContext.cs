﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Helpdesk;
using WebApplicationHelpdeskDomain.Entities.Register;
using WebApplicationHelpdeskDomain.Entities.Ticket;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace WebApplicationHelpdeskInfrastructure.Database
{
   
    public class WebApplicationHelpdeskDbContext : IdentityDbContext
    {
        public WebApplicationHelpdeskDbContext(DbContextOptions<WebApplicationHelpdeskDbContext> options) : base(options)
        {

        }
        public DbSet<Client> clients { get; set; }
        public DbSet<UsersClient> usersClients { get; set; }
        public DbSet<TicketList> ticketLists { get; set; }
        public DbSet<TicketPriority> ticketPriority { get; set; }
        public DbSet<TicketStatus> ticketStatus { get; set; }
        public DbSet<TicketCreate> ticketCreates { get; set; }
        public DbSet<UsersHelpdesk> userHelpdesks { get; set; }
        public DbSet<RegisterForClient> userRegisterForClients { get; set; }
        public DbSet<RegisterForHelpdesk> userRegisterForHelpdesks { get; set; }
         
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  
        }

    }
 }



