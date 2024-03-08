using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskApi.Queries.ClientUsers;
using WebApplicationHelpdeskApi.Queries.HelpdeskUsers;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterUsersForHelpdeskController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterUsersForHelpdeskController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Create()
        {
            return View();
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
        public async Task<IActionResult> Details(string details)
        {
            var dto = await _mediator.Send(new GetRegisterUserHelpdeskQuery(details));
            return View(dto);
        }
        public async Task<IActionResult> Index()
        {

            var userHelpdesk = await _mediator.Send(new GetAllRegisterUserHelpdeskQuery());
            return View(userHelpdesk);
        }
    }
}
