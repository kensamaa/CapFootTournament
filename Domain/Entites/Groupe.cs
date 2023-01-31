using System;
namespace Domain.Entites
{
	public class Groupe
	{
		public Guid Id { get; set; }
        public Guid TournamentId { get; set; }
        public string Name { get; set; }

        public Groupe()
		{
            Id = Guid.NewGuid();
        }
	}
}

