using FluentValidation;

namespace SIGSUC.Domain.Entities.Common.Validations
{
    public class ContinenteValidator : AbstractValidator<Continente>
    {
        public ContinenteValidator()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Informe o nome do País")
                .Length(3, 40).WithMessage("O nome deve ter no mínimo 3 caracteres e no máximo 40 caracteres");

        }
    }
}
