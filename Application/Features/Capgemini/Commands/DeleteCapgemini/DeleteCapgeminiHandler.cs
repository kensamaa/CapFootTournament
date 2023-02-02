using Application.Contracts.Repository;
using AutoMapper;
using MediatR;
using Domain.Exceptions;
namespace Application.Features.Capgemini.Commands.DeleteCapgemini;

public class DeleteCapgeminiHandler : IRequestHandler<DeleteCapgeminiCommand, Unit>
{
    private readonly ICapgeminiRepository _capgeminiRepository;
    public DeleteCapgeminiHandler( ICapgeminiRepository capgeminiRepository)
    {
        _capgeminiRepository = capgeminiRepository;
    }

    public async Task<Unit> Handle(DeleteCapgeminiCommand request, CancellationToken cancellationToken)
    {


        //retrieve domain entity object
        var CapgeminiToDelete =await _capgeminiRepository.GetByIdAsync(request.Id);

        //verify that record in database
        if (CapgeminiToDelete == null)
            throw new CapgeminiException(nameof(Capgemini),request.Id);

        //delete from database
        await _capgeminiRepository.DeleteAsync(CapgeminiToDelete);

        //return record id
        return Unit.Value;
    }
}
