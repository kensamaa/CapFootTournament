using System;
namespace Domain.Entites
{
	public class Card
	{
		public Guid Id { get; set; }
		public CardType Color { get; set; }
        public DateTime ReceptionDate { get; set; }
        public Card()
		{
			
		}
	}
}

