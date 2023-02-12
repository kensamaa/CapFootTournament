using Application.Features.Tournament.Queries.GetAllTournaments;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.HasData(
            new Tournament
            {
                Id = Guid.NewGuid(),
                Name = "Tournoi Ramadan",
                CountryOrganisation = "Maroc",
                isFinished = false,
                isStarted = false,
                isSignUpCompleted = false,
                //Capgeminis = new List<Capgemini>
                //{
                //    new Capgemini
                //    {

                //        Id = Guid.Parse("50630809-0da5-43c7-b8e1-08135a031773"),

                //    },
                //     new Capgemini
                //     {
                //         Id = Guid.Parse("2307aad8-f07b-497a-a02b-db23bc0c6ee0"),
                //     },

                //},
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
