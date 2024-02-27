using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Create(RegisterForHelpdesk registerForHelpdesk)
        {
           await _registerClientService.Create(registerForHelpdesk);
            return View();
            
        }
    }
}
