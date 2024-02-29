using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Dto.ValidationDto
{
    public class HelpdeskUserValidator : AbstractValidator<HelpdeskUserDto>
    {
        public HelpdeskUserValidator(IRegisterHelpdeskoRepository repository)
        {
            RuleFor(c => c.UserEmail)
                .NotEmpty()
                .MinimumLength(2).WithMessage("za mało znaków dla użytkownika")
                .MaximumLength(30).WithMessage("za dużo znaków dla użytkownika")
                .Custom((value, context) =>
                {
                    var nameHelpdeskUserExisting = repository.GetByName(value).Result;
                    if (nameHelpdeskUserExisting != null)
                    {
                        context.AddFailure($"{value} nie jest unikalna nazwą dla helpdesk");
                    }
                });
            RuleFor(c => c.UserName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("za mało znaków dla nazwy użytkownika")
                .MaximumLength(30).WithMessage("za dużo znaków dla nazwy użytkownika");
        }
    }
}
