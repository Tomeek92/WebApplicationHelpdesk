using Microsoft.AspNetCore.Mvc;
using WebApplicationHelpdeskApi;
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
        public async Task<IActionResult> Index() //główna strona z widokiem utworzonych kont klienta
        {
            var registerClient = await _registerClientService.GetAll();
            return View(registerClient);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ClientUserDto registerForClient)
        {
            if (!ModelState.IsValid)
            {
                return View(registerForClient);
            }
            await _registerClientService.Create(registerForClient);
            return View();
        }
    }
}
