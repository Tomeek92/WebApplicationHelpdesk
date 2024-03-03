using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskApi.Queries.ClientUsers
{
    public class GetAllRegisterClientQuery : IRequest<IEnumerable<ClientUserDto>>
    {

    }
}
