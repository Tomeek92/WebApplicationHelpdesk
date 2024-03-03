using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHelpdeskApi.Command.ClientUsers
{
    public class CreateClientUserCommand : ClientUserDto, IRequest
    {

    }
}
