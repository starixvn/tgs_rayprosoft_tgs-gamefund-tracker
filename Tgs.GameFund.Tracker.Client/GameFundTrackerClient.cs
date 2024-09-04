using System.Net.Http.Json;

namespace Tgs.GameFund.Tracker.Client;

internal class GameFundTrackerClient(HttpClient httpClient) : IGameFundTrackerClient
{
    public async ValueTask TraceGameFundAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default)
    {
        var response = await httpClient
            .PostAsJsonAsync(
                requestUri: "/tracker/trace",
                value: new
                {
                    gameProviderId,
                    walletId,
                    playerCode,
                },
                cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        _ = response.EnsureSuccessStatusCode();
    }
}
