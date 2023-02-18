using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Architecture.Tests;

public  class DbContextTests
{
	private readonly CapFootDatabaseContext _CapFootDataBaseContext;

	public DbContextTests()
	{
		var dbOptions = new DbContextOptionsBuilder<CapFootDatabaseContext>()
			.UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

		_CapFootDataBaseContext = new CapFootDatabaseContext(dbOptions);
	}
	[Fact]
	public  async void Save_SetDateCreatedValue()
	{
		//arrange
		var capgemini = new Capgemini()
		{
			Name = "TS",
			Country = "Morocco",
			City = "Casablanca",
			NumberOfTeams = 16
		};
		//act
		await _CapFootDataBaseContext.Capgeminis.AddAsync(capgemini);
		await _CapFootDataBaseContext.SaveChangesAsync();
		//assert
		Assert.NotNull(capgemini.DateCreated);
	}

	[Fact]
	public async void Save_SetDateModifiedValue()
	{
		//arrange
		var capgemini = new Capgemini()
		{
			Name = "TS",
			Country = "Morocco",
			City = "Casablanca",
			NumberOfTeams = 16
		};
		//act
		await _CapFootDataBaseContext.Capgeminis.AddAsync(capgemini);
		await _CapFootDataBaseContext.SaveChangesAsync();
		//assert
		Assert.NotNull(capgemini.DateModified);
	}
}
