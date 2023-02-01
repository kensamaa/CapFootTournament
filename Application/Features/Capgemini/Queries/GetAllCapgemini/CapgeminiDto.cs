﻿using System;
namespace Application.Features.Capgemini.Queries.GetAllCapgemini
{
	public class CapgeminiDto
	{
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
    }
}

