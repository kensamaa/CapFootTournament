using MediatR;

namespace Application.Features.Capgemini.Commands.CreateCapgemini
{
    public class CreateCapgeminiCommand : IRequest<Guid>
    {
        public string Name { get; set; }=string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
    }
}
