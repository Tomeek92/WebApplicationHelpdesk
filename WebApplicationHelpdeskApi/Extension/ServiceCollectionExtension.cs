using Microsoft.Extensions.DependencyInjection;
using WebApplicationHelpdeskApi.Service.ServiceRegisterClient;
using WebApplicationHelpdeskApi.Service.ServiceRegisterHelpdesk;
using WebApplicationHelpdeskApi.Service.ServiceTicketCreate;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRegisterClientService, RegisterClientService>();
            services.AddScoped<IRegisterHelpdeskService, RegisterHelpdeskService>();
            services.AddScoped<IRegisterTicketService,RegisterTicketService>();
        }
    }
}
