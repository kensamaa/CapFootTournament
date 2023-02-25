﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Player.Queries.GetPlayers
{
	public class PlayerDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string FamilyName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public bool IsCaptain { get; set; }
	}
}
