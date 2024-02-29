using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskDomain.Interfaces;

namespace WebApplicationHelpdeskApi.Dto.ValidationDto
{
    public class TicketCreateValidator : AbstractValidator<TicketCreateDto>
    {
        public TicketCreateValidator(IRegisterTicketRepository repository)
        {
            RuleFor(c => c.Title)
                .NotEmpty()
                .MaximumLength(300).WithMessage("Zbyt dużo znaków")
                .MinimumLength(10).WithMessage("Zbyt mało znaków")
                .Custom((value, context) =>
                {
                    var nameHelpdeskUserExisting = repository.GetByName(value).Result;
                    if (nameHelpdeskUserExisting != null)
                    {
                        context.AddFailure($"{value} nie jest unikalna nazwą dla ticketu");
                    }
                });
            RuleFor(c => c.Description)
                .NotEmpty()
                .MinimumLength(10).WithMessage("Zbyt mały opis");
            RuleFor(c => c.Status)
                .NotEmpty()
                .MinimumLength(5).WithMessage("Zbyt mały znaków w statusie");

        }
    }
}
