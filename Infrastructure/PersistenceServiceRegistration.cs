using System;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Infrastructure;

public static class PersistenceServiceRegistration
{
	public static IServiceCollection AddPersistanceService(this IServiceCollection services,IConfiguration configuration)
	{
		services.AddDbContext<CapFootDatabaseContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("CapFootDatabaseContext"));
		});

		return services;

	}
	
}

