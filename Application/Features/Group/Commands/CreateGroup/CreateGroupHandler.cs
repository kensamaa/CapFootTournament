using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

namespace Application.Features.Group.Commands.CreateGroup
{
	public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, Guid>
	{
		private readonly IMapper _mapper;
		private readonly IGroupRepository _groupRepository;
		public CreateGroupHandler(IMapper mapper, IGroupRepository groupRepository)
		{
			_mapper = mapper;
			_groupRepository = groupRepository;
		}

		public async Task<Guid> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
		{
			//convert to domain entity object
			var GroupToCreate = _mapper.Map<Domain.Entites.Groupe>(request);
			//add to database
			await _groupRepository.CreateAsync(GroupToCreate);
			//return record id
			return GroupToCreate.Id;
		}
	}
}
