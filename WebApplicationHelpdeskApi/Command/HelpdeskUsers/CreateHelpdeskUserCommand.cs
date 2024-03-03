using MediatR;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Command.HelpdeskUsers
{
    public class CreateHelpdeskUserCommand : HelpdeskUserDto, IRequest
    {

    }
}
