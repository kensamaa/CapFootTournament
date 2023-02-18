using System;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Application.Contracts.Repository;
using Infrastructure.Repositories;
using Application.Contracts.Logging;
using Infrastructure.Logging;

namespace Infrastructure;

public static class PersistenceServiceRegistration
{
	public static IServiceCollection AddPersistanceService(this IServiceCollection services,IConfiguration configuration)
	{
		services.AddDbContext<CapFootDatabaseContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("CapFootDatabaseContext"));
		});
		services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
		//logger
		services.AddScoped(typeof(IAppLogger<>),typeof(LoggerAdapter<>));

		services.AddScoped<ICapgeminiRepository, CapgeminiRepository>();
        services.AddScoped<ITournamentRepository, TournamentRepository>();
		services.AddScoped<ICapgeminiTournament, CapgeminiTournamentRepository>();
		services.AddScoped<IGroupRepository, GroupRepository>();
        return services;

	}
}

