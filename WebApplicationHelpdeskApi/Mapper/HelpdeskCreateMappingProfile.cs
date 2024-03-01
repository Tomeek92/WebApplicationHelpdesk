
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Register;
using AutoMapper;

namespace WebApplicationHelpdeskApi.Mapper
{
    public class HelpdeskCreateMappingProfile : Profile
    {
        public HelpdeskCreateMappingProfile()
        {
            CreateMap<HelpdeskUserDto, RegisterForHelpdesk>();
            CreateMap<RegisterForHelpdesk, HelpdeskUserDto>();
        }
    }
}
