using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi;
using WebApplicationHelpdeskApi.Command.ClientUsers;
using WebApplicationHelpdeskApi.Queries;
using WebApplicationHelpdeskApi.Queries.ClientUsers;
using WebApplicationHelpdeskDomain.Entities.Register;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterUsersForClientsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RegisterUsersForClientsController(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index() //główna strona z widokiem utworzonych kont klienta
        {
            var registerClient = await _mediator.Send(new GetAllRegisterClientQuery());
            return View(registerClient);
        }
        
        
        public async Task<IActionResult> Details(string details)
        {
          var dto = await _mediator.Send(new GetRegisterClientUserQuery(details));
            return View(dto);
        }
       
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {

            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateClientUserCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return View();
        }

    }

}
