
using FluentValidation;

namespace SIGSUC.Domain.Entities.Common.Validations
{
    public class PaisValidator : AbstractValidator<Pais>
    {
        public PaisValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe o nome do País")
                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 caracteres e no máximo 100 caracteres");

            RuleFor(x => x.ContinenteId)
                .NotEmpty().WithMessage("Informe o Continente que pertence esse país");
        }
    }
}
