using System.Text.Json;
using Tgs.GameFund.Tracker.Core;
using Tgs.GameFund.Tracker.Core.ApplicationServices;
using Tgs.ServiceUtility;
using Valhalla.MessageQueue;

namespace Tgs.GameFund.Tracker.Messages;

public class TraceMessageHandler(
	ILogger<TraceMessageHandler> logger,
	ICommandService<HandleTrackCommand> service) : IMessageHandler<ReadOnlyMemory<byte>>
{
	public ValueTask HandleAsync(string subject, ReadOnlyMemory<byte> data, IEnumerable<MessageHeaderValue>? headerValues, CancellationToken cancellationToken = default)
	{
		var message = JsonSerializer.Deserialize<GameFundTraceMessage>(data.Span)
			?? throw new NullReferenceException("The request data resolves to a null value");

		logger.LogInformation("{logInformation}",
			JsonSerializer.Serialize(new
			{
				LogOn = DateTime.Now.ToString("u"),
				Subject = subject,
				Data = new
				{
					message.GameProviderId,
					message.WalletId,
					message.PlayerCode,
				},
				Message = "This message receiving handler."
			}));

		return service.ExecuteAsync(
			command: new HandleTrackCommand(message),
			cancellationToken: cancellationToken);
	}
}
