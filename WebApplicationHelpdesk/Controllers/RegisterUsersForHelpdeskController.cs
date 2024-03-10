using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApplicationHelpdesk.Extension;
using WebApplicationHelpdesk.Models;
using WebApplicationHelpdeskApi.Dto;
using WebApplicationHelpdeskApi.Queries.ClientUsers;
using WebApplicationHelpdeskApi.Queries.HelpdeskUsers;


namespace WebApplicationHelpdesk.Controllers
{
    public class RegisterUsersForHelpdeskController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<IdentityUser> _allUsers;
        public RegisterUsersForHelpdeskController(IMediator mediator,UserManager<IdentityUser> allUsers)
        {
            _mediator = mediator;
            _allUsers = allUsers;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(HelpdeskUserDto registerForHelpdesk)
        {
            if(!ModelState.IsValid)
            {
                return View(registerForHelpdesk);
            }
            await _mediator.Send(registerForHelpdesk);

            this.SetNotification("success", $"Stworzono!{registerForHelpdesk.UserName}");

            return View(registerForHelpdesk);
            
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllUsers()
        {
            var users = await _allUsers.Users.ToListAsync();
            return View(users);
        }
    }
}
