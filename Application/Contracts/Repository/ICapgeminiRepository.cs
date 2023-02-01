using System;
using Domain.Entites;

namespace Application.Contracts.Repository
{
	public interface ICapgeminiRepository : IGenericRepository<Capgemini>
	{
		Task<bool> IsCapgeminiUnique(string name);
		//we enhirite from the generic repo to enherit de general functions 
	}
}

