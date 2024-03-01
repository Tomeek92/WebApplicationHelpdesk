using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskApi.Service.ServiceRegisterClient;
using WebApplicationHelpdeskApi.Service.ServiceRegisterHelpdesk;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterForHelpdeskController : Controller
    {
        private readonly IRegisterHelpdeskService _registerClientService;
        public RegisterForHelpdeskController(IRegisterHelpdeskService registerHelpdeskService)
        {
            _registerClientService = registerHelpdeskService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(HelpdeskUserDto registerForHelpdesk)
        {
            if(!ModelState.IsValid)
            {
                return View(registerForHelpdesk);
            }
           await _registerClientService.Create(registerForHelpdesk);
            return View();
            
        }
        public async Task<IActionResult> Index()
        {

            var userHelpdesk = await _registerClientService.GetAll();
            return View(userHelpdesk);
        }
    }
}
