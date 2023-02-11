
using Application.Contracts.Repository;
using Application.Features.Capgemini.Commands.CreateCapgemini;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.Features.Tournament.Commands.CreateTournament
{
    public class CreateTournamentValidator : AbstractValidator<CreateTournamentCommand>
    {
        public CreateTournamentValidator() {
            
            RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required").NotNull();
        }

       
    }
}
