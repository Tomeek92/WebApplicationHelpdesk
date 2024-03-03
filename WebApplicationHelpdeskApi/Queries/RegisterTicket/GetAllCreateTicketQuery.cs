using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Command.RegisterTicket;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Queries.RegisterTicket
{
    public class GetAllCreateTicketQuery : IRequest<IEnumerable<TicketCreateDto>>
    {

    }
}
