using Application.Contracts.Repository;
using Application.Features.Capgemini.Commands.UpdateCapgemini;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Commands.UpdateTournament;

public class UpdateTournamentHandler : IRequestHandler<UpdateTournamentCommand, Unit>
{
    private readonly IMapper mMapper;
    private readonly ITournamentRepository mTournamentRepository;

    public UpdateTournamentHandler(IMapper pMapper, ITournamentRepository pTournamentRepository)
    {
        this.mMapper = pMapper;
        this.mTournamentRepository = pTournamentRepository;
    }

    public async Task<Unit> Handle(UpdateTournamentCommand request, CancellationToken cancellationToken)
    {
        if(!request.isStarted || !request.isFinished)
        {
            //convert to domain entity object
            var TournamentToUpdate = mMapper.Map<Domain.Entites.Tournament>(request);
            //add to database
            await mTournamentRepository.UpdateAsync(TournamentToUpdate);
        }
        return Unit.Value;
        
    }

}
