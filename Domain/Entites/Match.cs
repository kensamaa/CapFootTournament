﻿using System;
using Domain.Common;

namespace Domain.Entites;

public sealed class Match:Entity
{

	public Guid TeamAId { get; set; }
	public Guid TeamBId { get; set; }
	public int NumberGoalsTeamA { get; set; }
	public int NumberGoasTeamB { get; set; }
	public DateTime MatchStart { get; set; }
	public DateTime MathEnd { get; set; }
	public string RefereeName { get; set; } = string.Empty;

}

