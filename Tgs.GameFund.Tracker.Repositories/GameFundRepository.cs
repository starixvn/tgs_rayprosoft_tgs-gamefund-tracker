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
	public async ValueTask SaveAsync(GameFundTraceMessage message, CancellationToken cancellationToken = default)
	{
		logger.LogDebug(nameof(SaveAsync));

		var systemTime = DateTime.UtcNow;

		var entity = await tgsDbContext.GameFundTransferTraces
			.FirstOrDefaultAsync(
				e =>
					e.GameProviderId == message.GameProviderId &&
					e.WalletId == message.WalletId &&
					e.PlayerCode == message.PlayerCode,
				cancellationToken)
			.ConfigureAwait(false);

		if (entity is null)
		{
			entity = new()
			{
				GameProviderId = message.GameProviderId,
				WalletId = message.WalletId,
				PlayerCode = message.PlayerCode,
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
