namespace Tgs.GameFund.Tracker.Core;

public interface IGameFundRepository
{
	ValueTask SaveAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default);
}
