namespace Tgs.GameFund.Tracker.Client;

public interface IGameFundTrackerClient
{
    ValueTask TraceGameFundAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default);
}
