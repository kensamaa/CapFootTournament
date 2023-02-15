using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Group.Commands.CreateGroup
{
	public class CreateGroupCommand : IRequest<Guid>
	{
		public Guid TournamentId { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
