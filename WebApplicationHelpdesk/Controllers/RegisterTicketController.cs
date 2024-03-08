﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
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
            return View();
        }
        public async Task <IActionResult> Index()
        {
            var registerTicket = await _mediator.Send(new GetAllCreateTicketQuery());
            return View(registerTicket);
        }

    }
}
