using Microsoft.Extensions.Logging;
using Tgs.ServiceUtility;

namespace Tgs.GameFund.Tracker.Core.ApplicationServices;

internal class HandleTrackCommandService(
	ILogger<HandleTrackCommandService> logger,
	IGameFundRepository repository) : ICommandService<HandleTrackCommand>
{
	public async ValueTask ExecuteAsync(HandleTrackCommand command, CancellationToken cancellationToken = default)
	{
		logger.LogInformation(nameof(ExecuteAsync));

		try
		{
			await repository
				.SaveAsync(
					gameProviderId: command.GameProviderId,
					walletId: command.WalletId,
					playerCode: command.PlayerCode,
					cancellationToken: cancellationToken)
				.ConfigureAwait(false);
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "{logError}",
				new
				{
					LogOn = DateTime.Now.ToString("u"),
					Data = new
					{
						command.GameProviderId,
						command.WalletId,
						command.PlayerCode
					},
					exception.Message
				});
		}
	}
}
