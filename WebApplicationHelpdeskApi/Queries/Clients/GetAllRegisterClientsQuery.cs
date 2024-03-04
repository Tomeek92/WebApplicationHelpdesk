using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Queries.Clients
{
    public class GetAllRegisterClientsQuery : IRequest<IEnumerable<ClientDto>>
    {

    }
}
