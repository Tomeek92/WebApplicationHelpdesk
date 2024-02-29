﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Interfaces;


namespace WebApplicationHelpdeskApi.Dto.ValidationDto
{
    public class ClientUserValidator : AbstractValidator<ClientUserDto>
    {
        public ClientUserValidator(IRegisterClientRepository repository)
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Nazwa jest zbyt krótka")
                .MaximumLength(20).WithMessage("Zbyt dużo znaków")
                .Custom((value, context) =>
                 {
                     var nameExistingNameClient = repository.GetByName(value).Result;
                     if(nameExistingNameClient != null)
                     {
                         context.AddFailure($"{value} nie jest unikalna nazwą dla klienta");
                     }
                 });
            RuleFor(c => c.Email)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Email jest zbyt krótki")
                .MaximumLength(30).WithMessage("przekroczyłeś liczbę znaków dla email");
        }
    }
}
