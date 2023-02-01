
using System;
using System.Reflection.Emit;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CapgeminiConfiguration : IEntityTypeConfiguration<Capgemini>
    {
        public void Configure(EntityTypeBuilder<Capgemini> builder)
        {
            builder.HasData(
            new Capgemini
            {
                Id = Guid.NewGuid(),
                Name = "TS",
                Country = "Morocco",
                City = "Casablanca",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            });
            builder.Property(q => q.Id).IsRequired();
            builder.Property(q => q.Name).IsRequired();
            builder.Property(q => q.City).IsRequired();
            builder.Property(q => q.Country).IsRequired();
        }
    }
}

