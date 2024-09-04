using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Tgs.GameFund.Tracker.Entities;

namespace Tgs.GameFund.Tracker.Repositories.UnitTest;

public class GameFundRepositoryUnitTest
{
	[Fact]
	public async Task AddGameFundTrace_WithNewly()
	{
		// Arrange
		var gameProviderId = Guid.NewGuid();
		var walletId = Guid.NewGuid();
		var playerCode = "4ucmqplxb029";
		var options = new DbContextOptionsBuilder<TgsContext>()
			.UseInMemoryDatabase(Guid.NewGuid().ToString())
			.Options;

		var fakeLogger = NullLogger<GameFundRepository>.Instance;
		var fakeContext = new TgsContext(options);
		var sut = new GameFundRepository(fakeLogger, fakeContext);

		// Act
		await sut.SaveAsync(
			gameProviderId: gameProviderId,
			walletId: walletId,
			playerCode: playerCode,
			cancellationToken: default);

		// Assert
		var actual = await fakeContext.GameFundTransferTraces.SingleAsync();
		Assert.Equal(gameProviderId, actual.GameProviderId);
		Assert.Equal(walletId, actual.WalletId);
		Assert.Equal("4ucmqplxb029", actual.PlayerCode);
	}

	[Fact]
	public async Task UpdateGameFundTrace_WithExists()
	{
		// Arrange
		var gameProviderId = Guid.NewGuid();
		var walletId = Guid.NewGuid();
		var playerCode = "4ucmqplxb029";
		var systemTime = DateTime.UtcNow;
		var options = new DbContextOptionsBuilder<TgsContext>()
			.UseInMemoryDatabase(Guid.NewGuid().ToString())
			.Options;

		using (var prepareContext = new TgsContext(options))
		{
			await prepareContext.GameFundTransferTraces
				.AddAsync(new()
				{
					GameProviderId = gameProviderId,
					WalletId = walletId,
					PlayerCode = playerCode,
					CreatedOn = systemTime,
					UpdatedOn = systemTime
				}, default)
				.ConfigureAwait(true);
			await prepareContext
				.SaveChangesAsync(default)
				.ConfigureAwait(true);
		}

		var fakeLogger = NullLogger<GameFundRepository>.Instance;
		var fakeContext = new TgsContext(options);
		var sut = new GameFundRepository(fakeLogger, fakeContext);

		// Act
		await sut.SaveAsync(
			gameProviderId: gameProviderId,
			walletId: walletId,
			playerCode: playerCode,
			cancellationToken: default);

		// Assert
		var actual = await fakeContext.GameFundTransferTraces.SingleAsync();
		Assert.Equal(gameProviderId, actual.GameProviderId);
		Assert.Equal(walletId, actual.WalletId);
		Assert.Equal("4ucmqplxb029", actual.PlayerCode);
	}
}
