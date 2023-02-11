using Application.Contracts.Repository;
using Application.Features.Capgemini.Commands.CreateCapgemini;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Commands.CreateTournament
{
    public class CreateTournamentHandler : IRequestHandler<CreateTournamentCommand, Guid>
    {
        private readonly IMapper mMapper;
        private readonly ITournamentRepository mTournamentRepository;

        public CreateTournamentHandler(IMapper pMapper, ITournamentRepository pTournamentRepository)
        {
            this.mMapper= pMapper;
            this.mTournamentRepository= pTournamentRepository;
        }
        public async Task<Guid> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
        {
            //validate incoming data
            var validator = new CreateTournamentValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
                throw new TournamentException("invalid Tournament", validationResult);

            //convert to domain entity object
            var TournamentToCreate = mMapper.Map<Domain.Entites.Tournament>(request);
            //add to database
            await mTournamentRepository.CreateAsync(TournamentToCreate);
            //return record id
            return TournamentToCreate.Id;
        }
    }
}
