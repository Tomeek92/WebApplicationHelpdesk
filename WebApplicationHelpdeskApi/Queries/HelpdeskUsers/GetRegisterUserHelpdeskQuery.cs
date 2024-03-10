using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskApi.Queries.HelpdeskUsers
{
    public class GetRegisterUserHelpdeskQuery : IRequest<HelpdeskUserDto>
    {
        public string UserName { get; set; }
        public GetRegisterUserHelpdeskQuery(string userName)
        {
            UserName = userName;
        }
    }
}
