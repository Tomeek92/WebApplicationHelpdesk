﻿using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationHelpdesk.OnlineUsers;
using WebApplicationHelpdeskApi.Command.Client;
using WebApplicationHelpdeskApi.Command.ClientUsers;
using WebApplicationHelpdeskApi.Command.ClientUsers.Validators;
using WebApplicationHelpdeskApi.Command.HelpdeskUsers;
using WebApplicationHelpdeskApi.Command.HelpdeskUsers.Validators;
using WebApplicationHelpdeskApi.Command.RegisterTicket;
using WebApplicationHelpdeskApi.Command.RegisterTicket.Validator;
using WebApplicationHelpdeskApi.Mapper;




namespace WebApplicationHelpdeskApi.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserContext,UserContext>();
            services.AddMediatR(typeof(CreateClientUserCommand));
            services.AddMediatR(typeof(CreateHelpdeskUserCommand));
            services.AddMediatR(typeof(TicketCreateCommand));
            services.AddMediatR(typeof(CreateClientCommand));
            services.AddAutoMapper(typeof(ClientCreateMappingProfile));
            services.AddAutoMapper(typeof(ClientMappingProfile));
            services.AddAutoMapper(typeof(HelpdeskCreateMappingProfile));
            services.AddAutoMapper(typeof(TicketCreateMappingProfile));
            services.AddValidatorsFromAssemblyContaining<ClientUserCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();//po stronie frontendu reguly walidacji
            services.AddValidatorsFromAssemblyContaining<HelpdeskUserCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssemblyContaining<TicketCreateCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
