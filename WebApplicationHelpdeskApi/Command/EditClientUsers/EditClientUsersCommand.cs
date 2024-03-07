using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;

namespace WebApplicationHelpdeskApi.Command.EditClientUsers
{
    public class EditClientUsersCommand : ClientDto, IRequest
    {

    }
}
