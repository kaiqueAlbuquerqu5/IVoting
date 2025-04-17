using Application.Models.Register;
using FluentValidation;

namespace Application.Validators
{
    public class RegisterHostValidator : AbstractValidator<RegisterHostRequest>
    {
        public RegisterHostValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("O e-mail deve ser válido.");
        }
    }
}
