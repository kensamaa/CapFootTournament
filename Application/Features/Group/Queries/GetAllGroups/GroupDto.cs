﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Group.Queries.GetAllGroups
{
	public class GroupDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
