using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationHelpdeskApi.Dto.ValidationDto;
using WebApplicationHelpdeskApi.Mapper;
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
            services.AddAutoMapper(typeof(ClientCreateMappingProfile));
            services.AddAutoMapper(typeof(HelpdeskCreateMappingProfile));
            services.AddValidatorsFromAssemblyContaining<ClientUserValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();//po stronie frontendu reguly walidacji
            services.AddValidatorsFromAssemblyContaining<HelpdeskUserValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssemblyContaining<TicketCreateValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
