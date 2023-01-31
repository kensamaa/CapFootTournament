using System;
namespace Domain.Entites
{
	public class Tournament
	{
		public Guid Id { get; set; }
		public String Name { get; set; }
		public DateTime CreatedAt { get; set; }

		public Tournament()
		{

		}
	}
}

