using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationHelpdeskDomain.Interfaces;
using WebApplicationHelpdeskInfrastructure.Database.Seeders;
using WebApplicationHelpdeskInfrastructure.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplicationHelpdeskInfrastructure.Database.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebApplicationHelpdeskDbContext>(options => options.UseSqlServer(
           configuration.GetConnectionString("WebApplicationHelpdesk"),
           b => b.MigrationsAssembly("WebApplicationHelpdesk")));
            


            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddDefaultUI()
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
