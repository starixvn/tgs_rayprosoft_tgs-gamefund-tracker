using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tgs.GameFund.Tracker.Core;
using Tgs.GameFund.Tracker.Entities;

namespace Tgs.GameFund.Tracker.Repositories;

internal class GameFundRepository(
	ILogger<GameFundRepository> logger,
	TgsContext TgsContext
	) : IGameFundRepository
{
	public async ValueTask SaveAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default)
	{
		logger.LogDebug(nameof(SaveAsync));

		var systemTime = DateTime.UtcNow;

		var entity = await TgsContext.GameFundTransferTraces
			.FirstOrDefaultAsync(
				e =>
					e.GameProviderId == gameProviderId &&
					e.WalletId == walletId &&
					e.PlayerCode == playerCode,
				cancellationToken)
			.ConfigureAwait(false);

		if (entity is null)
		{
			entity = new()
			{
				GameProviderId = gameProviderId,
				WalletId = walletId,
				PlayerCode = playerCode,
				CreatedOn = systemTime,
				UpdatedOn = systemTime
			};
			await TgsContext.GameFundTransferTraces
				.AddAsync(entity, cancellationToken)
				.ConfigureAwait(false);
		}
		else
		{
			entity.UpdatedOn = systemTime;
		}

		await TgsContext
			.SaveChangesAsync(cancellationToken)
			.ConfigureAwait(false);
	}
}
