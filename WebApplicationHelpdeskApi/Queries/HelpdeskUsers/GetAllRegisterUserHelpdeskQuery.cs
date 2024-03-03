using MediatR;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Queries.HelpdeskUsers
{
    public class GetAllRegisterUserHelpdeskQuery : IRequest<IEnumerable<HelpdeskUserDto>>
    {

    }
}
