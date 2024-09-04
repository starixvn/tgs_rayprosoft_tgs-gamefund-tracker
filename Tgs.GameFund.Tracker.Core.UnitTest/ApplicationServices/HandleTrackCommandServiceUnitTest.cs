using Microsoft.Extensions.Logging.Abstractions;
using NSubstitute;
using Tgs.GameFund.Tracker.Core.ApplicationServices;

namespace Tgs.GameFund.Tracker.Core.UnitTest.ApplicationServices;

public class HandleTrackCommandServiceUnitTest
{
	[Fact]
	public async Task NormalProcess()
	{
		// Arrange
		var gameProviderId = Guid.NewGuid();
		var walletId = Guid.NewGuid();
		var playerCode = "4ucmqplxb029";

		var fakeLogger = NullLogger<HandleTrackCommandService>.Instance;
		var fakeRepository = Substitute.For<IGameFundRepository>();
		var sut = new HandleTrackCommandService(fakeLogger, fakeRepository);
		var command = new HandleTrackCommand(
			GameProviderId: gameProviderId,
			WalletId: walletId,
			PlayerCode: playerCode);

		// Act
		await sut.ExecuteAsync(
			command: command,
			cancellationToken: default);

		// Assert
		_ = fakeRepository
			.Received(1)
			.SaveAsync(
				gameProviderId: Arg.Is(gameProviderId),
				walletId: Arg.Is(walletId),
				playerCode: Arg.Is(playerCode),
				cancellationToken: Arg.Any<CancellationToken>())
			.ConfigureAwait(true);
	}
}
