﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database.Seeders;
using WebApplicationHelpdeskInfrastructure.Repository;

namespace WebApplicationHelpdeskInfrastructure.Database.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebApplicationHelpdeskDbContext>(options => options.UseSqlServer(
           configuration.GetConnectionString("WebApplicationHelpdesk"),
           b => b.MigrationsAssembly("WebApplicationHelpdesk")));

            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
           .AddEntityFrameworkStores<WebApplicationHelpdeskDbContext>();
            

            services.AddScoped<ClientSeeder>();
            services.AddScoped<UserClientSeeder>();
            services.AddScoped<TicketListSeeder>();
            services.AddScoped<TicketPrioritySeeder>();
            services.AddScoped<TicketStatusSeeder>();   
            services.AddScoped<UserHelpdeskSeeder>();
            services.AddScoped<RegisterForClientSeeder>();
            services.AddScoped<RegisterForHelpdeskSeeder>();
            services.AddScoped<IRegisterUserForClientRepository, RegisterUsersForClientRepository>();
            services.AddScoped<IRegisterHelpdeskoRepository, RegisterForHelpdeskRepository>();
            services.AddScoped<IRegisterTicketRepository, RegisterTicketRepository>();
            services.AddScoped<IRegisterClientRepository, RegisterForClientRepository>();
        }
    }
}
