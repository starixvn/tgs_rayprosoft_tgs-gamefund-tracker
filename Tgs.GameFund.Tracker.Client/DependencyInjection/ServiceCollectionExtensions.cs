using Tgs.GameFund.Tracker.Client;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddGameFundTransferClient(this IServiceCollection services, Action<IHttpClientBuilder> httpClientConfigure)
	{
		httpClientConfigure(services.AddHttpClient<IGameFundTrackerClient, GameFundTrackerClient>());
		return services;
	}
}
