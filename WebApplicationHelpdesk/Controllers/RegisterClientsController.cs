using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Command.Client;
using WebApplicationHelpdeskApi.Queries.Clients;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterClientsController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterClientsController(IMediator mediator)
        {
            _mediator = mediator;  
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateClientCommand createClient)
        {
            if(!ModelState.IsValid)
            {
                return View(createClient);
            }
            await _mediator.Send(createClient);
            return View();
        }
        public async Task<IActionResult> Index() //główna strona z widokiem utworzonych kont klienta
        {
            var registerClient = await _mediator.Send(new GetAllRegisterClientsQuery());
            return View(registerClient);
        }
    }
}
