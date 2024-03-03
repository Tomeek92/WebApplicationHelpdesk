using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskApi.Queries.HelpdeskUsers;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterForHelpdeskController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterForHelpdeskController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(HelpdeskUserDto registerForHelpdesk)
        {
            if(!ModelState.IsValid)
            {
                return View(registerForHelpdesk);
            }
           await _mediator.Send(registerForHelpdesk);
            return View();
            
        }
        public async Task<IActionResult> Index()
        {

            var userHelpdesk = await _mediator.Send(new GetAllRegisterUserHelpdeskQuery());
            return View(userHelpdesk);
        }
    }
}
