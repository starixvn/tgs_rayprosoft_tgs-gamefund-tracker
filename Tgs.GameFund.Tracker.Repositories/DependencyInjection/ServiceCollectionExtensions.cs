using Microsoft.EntityFrameworkCore;
using Tgs.GameFund.Tracker.Core;
using Tgs.GameFund.Tracker.Repositories;
using Tgs.GameFund.Tracker.Entities;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddGameFundTrackerRepository(
		this IServiceCollection services,
		Action<IServiceProvider, DbContextOptionsBuilder> efConfigure)
		=> services
		.AddDbContext<TgsContext>(efConfigure)
		.AddTransient<IGameFundRepository, GameFundRepository>();
}
