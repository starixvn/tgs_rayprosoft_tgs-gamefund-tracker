namespace Tgs.GameFund.Tracker.Core;

public interface IGameFundRepository
{
	ValueTask SaveAsync(GameFundTraceMessage message, CancellationToken cancellationToken = default);
}
