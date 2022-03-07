namespace services
{
    using domain.Entidades;
    using FluentValidation;

    public class DividerValidator : AbstractValidator<Divider>
    {
        public DividerValidator()
        {
            RuleFor(x => x.Number)
                .NotEmpty()
                .WithMessage("Numero não pode ser nulo ou vazio.");                           
            RuleFor(x => x.Prime)
                .Must(x => x == false || x == true)
                .WithMessage("Primo deve ser true/false.");
        }
    }
}