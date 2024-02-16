using FluentValidation;
using Saman.Domain.Entities;

namespace Saman.Application.Validators;

public class CreateUserValidator : AbstractValidator<User>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.FirstName)
            .NotEmpty()
            .Length(2, 100)
            .Must(u => u.All(char.IsLetter)).WithMessage("FirstName can not contain digits");

        RuleFor(u => u.LastName)
            .NotEmpty()
            .Length(2, 150)
            .Must(u => u.All(char.IsLetter)).WithMessage("LastName can not contain digits");

        RuleFor(u => u.FirstName)
            .NotEmpty()
            .EmailAddress();
    }
}
