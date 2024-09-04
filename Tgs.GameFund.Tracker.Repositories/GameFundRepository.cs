using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tgs.GameFund.Tracker.Core;
using Tgs.GameFund.Tracker.Repositories.Entities;

namespace Tgs.GameFund.Tracker.Repositories;

internal class GameFundRepository(
	ILogger<GameFundRepository> logger,
	TgsDbContext tgsDbContext
	) : IGameFundRepository
{
	public async ValueTask SaveAsync(Guid gameProviderId, Guid walletId, string playerCode, CancellationToken cancellationToken = default)
	{
		logger.LogDebug(nameof(SaveAsync));

		var systemTime = DateTime.UtcNow;

		var entity = await tgsDbContext.GameFundTransferTraces
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
			await tgsDbContext.GameFundTransferTraces
				.AddAsync(entity, cancellationToken)
				.ConfigureAwait(false);
		}
		else
		{
			entity.UpdatedOn = systemTime;
		}

		await tgsDbContext
			.SaveChangesAsync(cancellationToken)
			.ConfigureAwait(false);
	}
}
