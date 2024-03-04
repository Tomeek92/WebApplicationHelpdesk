using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Entities.Clients;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskApi.Mapper
{
    public  class ClientCreateMappingProfile : Profile
    {
        public ClientCreateMappingProfile()
        {
            CreateMap<ClientUserDto, RegisterForClient>();
            CreateMap<RegisterForClient, ClientUserDto>();

        }
    }
}
