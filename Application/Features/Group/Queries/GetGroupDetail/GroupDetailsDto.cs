namespace Application.Features.Group.Queries.GetGroupDetail
{
    public class GroupDetailsDto
    {
        public Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid TournamentId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
