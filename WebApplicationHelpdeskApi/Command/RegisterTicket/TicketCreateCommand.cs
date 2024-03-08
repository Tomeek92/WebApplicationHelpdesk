using MediatR;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Command.RegisterTicket
{
    public class TicketCreateCommand : TicketCreateDto, IRequest
    {

    }
}
