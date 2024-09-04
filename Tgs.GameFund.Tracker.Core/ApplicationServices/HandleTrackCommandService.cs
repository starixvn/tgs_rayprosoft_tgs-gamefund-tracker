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

		var message = command.Message;
		try
		{
			await repository.SaveAsync(message, cancellationToken).ConfigureAwait(false);
		}
		catch (Exception exception)
		{
			logger.LogWarning(exception, "{logWarning}",
				new
				{
					LogOn = DateTime.Now.ToString("u"),
					Data = new
					{
						message.GameProviderId,
						message.WalletId,
						message.PlayerCode
					},
					exception.Message
				});
		}
	}
}
