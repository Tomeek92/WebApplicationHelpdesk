using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskApi.Queries.RegisterTicket;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterTicketController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterTicketController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(TicketCreateDto ticketCreate)
        {
            if(!ModelState.IsValid)
            {
                return View(ticketCreate);
            }
            await _mediator.Send(ticketCreate);
            return View();
        }
        public async Task <IActionResult> Index()
        {
            var registerTicket = await _mediator.Send(new GetAllCreateTicketQuery());
            return View(registerTicket);
        }

    }
}
