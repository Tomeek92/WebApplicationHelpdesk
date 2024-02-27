using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi.Service.ServiceRegisterClient;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterForClientsController : Controller
    {
        private readonly IRegisterClientService _registerClientService;

        public RegisterForClientsController(IRegisterClientService registerClient)
        {
            _registerClientService = registerClient;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RegisterForClient registerForClient)
        {
            await _registerClientService.Create(registerForClient);
            return View();
        }
    }
}
