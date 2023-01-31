using System;
namespace Domain.Entites
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public Guid TeamId { get; set; }
        public List<Card> Cards { get; set; }

        public Player()
        {
            Id = Guid.NewGuid();
        }
    }
}

