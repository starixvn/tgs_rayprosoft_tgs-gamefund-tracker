using Tgs.GameFund.Client;
using Tgs.GameFund.Tracker.Core;

namespace Tgs.GameFund.Tracker.Repositories;

internal class GameFundRepository(IGameFundClient gameFundClient) : IGameFundRepository
{
	public ValueTask SaveAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default)
		=> gameFundClient.GameFundTransferTraceSaveAsync(
			gameProviderId: gameProviderId,
			walletId: walletId,
			playerCode: playerCode,
			cancellationToken: cancellationToken);
}
