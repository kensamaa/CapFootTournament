using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entites;
using Domain.Common;
namespace Infrastructure.DatabaseContext;

public class CapFootDatabaseContext : DbContext
{
	public CapFootDatabaseContext(DbContextOptions<CapFootDatabaseContext>options
		) : base(options)
	{

	}
	public DbSet<Capgemini> Capgeminis { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(CapFootDatabaseContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
		foreach (var entry in base.ChangeTracker.Entries<Entity>()
			.Where(q=>q.State==EntityState.Added || q.State == EntityState.Modified))
		{
			entry.Entity.DateModified = DateTime.Now;
			if (entry.State == EntityState.Added)
            {
				entry.Entity.DateCreated = DateTime.Now;
            }
		}
        return base.SaveChangesAsync(cancellationToken);

    }
}

