using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Service.ServiceTicketCreate;
using WebApplicationHelpdeskDomain.Entities.Ticket;

namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterTicketController : Controller
    {
        private readonly IRegisterTicketService _registerTicketService;
        public RegisterTicketController(IRegisterTicketService registerTicketService)
        {
            _registerTicketService = registerTicketService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(TicketCreate ticketCreate)
        {
            await _registerTicketService.Create(ticketCreate);
            return View();
        }

    }
}
