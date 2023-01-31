
using System;
namespace Domain.Entites
{
	public class Team
	{
		public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid GroupeId { get; set; }
        public int Classement { get; set; }
        public int Points { get; set; }
        public string City { get; set; }
        public Team()
		{
            Id = Guid.NewGuid();
            Points = 0;
            Classement = 0;
        }
	}
}

