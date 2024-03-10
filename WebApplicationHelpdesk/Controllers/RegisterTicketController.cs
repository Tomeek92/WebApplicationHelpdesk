using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdesk.Extension;
using WebApplicationHelpdeskApi.Command.RegisterTicket;
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
        [Authorize(Roles = "Employee,Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Employee,Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(TicketCreateDto ticketCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(ticketCreateDto);
            }

            var ticketCreateCommand = new TicketCreateCommand
            {
                Title = ticketCreateDto.Title,
                Description = ticketCreateDto.Description,
                Status = ticketCreateDto.Status
            };

            await _mediator.Send(ticketCreateCommand);
            this.SetNotification("succes", $"Stworzono!: {ticketCreateCommand.Title}");
            return View();
        }
        public async Task <IActionResult> Index()
        {
            var registerTicket = await _mediator.Send(new GetAllCreateTicketQuery());
            return View(registerTicket);
        }

    }
}
