using NSubstitute;
using Tgs.GameFund.Client;

namespace Tgs.GameFund.Tracker.Repositories.UnitTest;

public class GameFundRepositoryUnitTest
{
	[Fact]
	public async Task Normal_Process()
	{
		// Arrange
		var gameProviderId = Guid.NewGuid();
		var walletId = Guid.NewGuid();
		var playerCode = "4ucmqplxb029";

		var fakeClient = Substitute.For<IGameFundClient>();
		var sut = new GameFundRepository(fakeClient);

		// Act
		await sut.SaveAsync(
			gameProviderId: gameProviderId,
			walletId: walletId,
			playerCode: playerCode,
			cancellationToken: default);

		// Assert
		await fakeClient
			.Received(1)
			.GameFundTransferTraceSaveAsync(
				gameProviderId: Arg.Is(gameProviderId),
				walletId: Arg.Is(walletId),
				playerCode: Arg.Is(playerCode),
				cancellationToken: Arg.Any<CancellationToken>());
	}
}
