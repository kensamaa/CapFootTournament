using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            var id = Guid.NewGuid();
            builder.HasData(
            new Tournament
            {
                Id = id,
                Name = "Tournoi Ramadan",
                CountryOrganisation = "Maroc",
                isFinished = false,
                isStarted = false,
                isSignUpCompleted = false,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            }
           );
            // builder.Property(q => q.Id).IsRequired();
            // builder.Property(q => q.Name).IsRequired();
            // builder.Property(q => q.CountryOrganisation).IsRequired();
            // builder.Property(q => q.Capgeminis).IsRequired();
        }
    }
}
