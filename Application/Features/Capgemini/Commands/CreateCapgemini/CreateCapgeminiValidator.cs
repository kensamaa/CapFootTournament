using FluentValidation;

namespace Application.Features.Capgemini.Commands.CreateCapgemini;


public class CreateCapgeminiValidator : AbstractValidator<CreateCapgeminiCommand>
{
	public CreateCapgeminiValidator()
	{
		RuleFor(p => p.Name)
			.NotEmpty().WithMessage("{PropertyName} is required").NotNull();
	}
}
