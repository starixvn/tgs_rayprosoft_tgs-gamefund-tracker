using Tgs.GameFund.Tracker.Core;
using Tgs.GameFund.Tracker.Repositories;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddGameFundTrackerRepository(this IServiceCollection services)
		=> services
		.AddTransient<IGameFundRepository, GameFundRepository>();
}
