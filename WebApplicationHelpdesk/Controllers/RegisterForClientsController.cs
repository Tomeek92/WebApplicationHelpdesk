using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi;
using WebApplicationHelpdeskApi.Command.ClientUsers;
using WebApplicationHelpdeskApi.Queries;
using WebApplicationHelpdeskApi.Queries.ClientUsers;
using WebApplicationHelpdeskDomain.Entities.Register;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterForClientsController : Controller
    {
        private readonly IMediator _mediator;

        public RegisterForClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index() //główna strona z widokiem utworzonych kont klienta
        {
            var registerClient = await _mediator.Send(new GetAllRegisterClientQuery());
            return View(registerClient);
        }
        public IActionResult Create()
        {
            return View();
        }
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
