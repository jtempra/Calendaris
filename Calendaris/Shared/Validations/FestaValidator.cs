
using Calendaris.Shared.Entities;
using FluentValidation;


namespace Calendaris.Shared.Validations
{
    public class FestaValidator : AbstractValidator<CalendariFestes>
    {
        public FestaValidator()
        {
            RuleFor(f => f.Data).NotEmpty().WithMessage("Has d'entrar una data");
                RuleFor(f => f.Festa).NotEmpty().MaximumLength(50).WithMessage("El nom de la festa no pot sobrepassar els 50 caractes");
                RuleFor(f => f.Tipus).NotEmpty().WithMessage("El tipus de festa no pot ser buit");
            }
    }
}
