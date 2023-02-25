using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entites;
using Domain.Common;
namespace Infrastructure.DatabaseContext;

public class CapFootDatabaseContext : DbContext
{
    public CapFootDatabaseContext(DbContextOptions<CapFootDatabaseContext> options
        ) : base(options)
    {
        this.Database.EnsureCreated();
    }
    public DbSet<Capgemini> Capgeminis { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Groupe> Groups { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
	public DbSet<CapgeminiTournament> CapgeminiTournaments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CapFootDatabaseContext).Assembly);
        //Begin configure many to many between Capgemini and Tournament
        modelBuilder.Entity<CapgeminiTournament>().HasKey(sc => new { sc.tournamentId, sc.capgeminiId });
        modelBuilder.Entity<CapgeminiTournament>()
        .HasOne(sc => sc.capgemini)
        .WithMany(s => s.capgeminiTournament)
        .HasForeignKey(sc => sc.capgeminiId);


        modelBuilder.Entity<CapgeminiTournament>()
            .HasOne(sc => sc.tournament)
            .WithMany(s => s.capgeminiTournament)
            .HasForeignKey(sc => sc.tournamentId);
        //End configure many to many between Capgemini and Tournament
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<Entity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
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

