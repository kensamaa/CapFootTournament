using Application.Contracts.Repository;
using Application.Features.Capgemini.Commands.DeleteCapgemini;
using Domain.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Group.Commands.DeleteGroup
{
	public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, Unit>
	{
		private readonly IGroupRepository _groupRepository;
		public DeleteGroupHandler(IGroupRepository groupRepository)
		{
			_groupRepository = groupRepository;
		}
		public async Task<Unit> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
		{
			var GroupToDelete = await _groupRepository.GetByIdAsync(request.Id);

			//verify that record in database
			if (GroupToDelete == null)
				throw new Exception();

			//delete from database
			await _groupRepository.DeleteAsync(GroupToDelete);

			//return record id
			return Unit.Value;
		}
	}
}
