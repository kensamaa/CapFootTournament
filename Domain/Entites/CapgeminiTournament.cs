namespace Domain.Entites
{
    public class CapgeminiTournament
    {
        public Guid capgeminiId { get; set; }
        public Capgemini capgemini { get; set; } = new Capgemini();
        public Guid tournamentId { get; set; }
        public Tournament tournament { get; set; } = new Tournament();
    }
}
