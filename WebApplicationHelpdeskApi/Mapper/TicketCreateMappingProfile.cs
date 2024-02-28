using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdeskApi.Mapper
{
    public class TicketCreateMappingProfile : Profile
    {
        public TicketCreateMappingProfile()
        {
            CreateMap<TicketCreateDto, TicketCreate>()
                .ForMember(e => e.Status, opt => opt.MapFrom(src => new TicketStatus()
                {
                    Status = src.Status
                }));
        }
    }
}
