using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NSubstitute;
using Tgs.GameFund.Tracker.Core;
using Valhalla.MessageQueue;

namespace Tgs.GameFund.Tracker.IntegrationTest;

public class TrackerTest
{
	[Fact]
	public async Task RequestTraceTest()
	{
		// Arrange
		var fakeMessageSender = Substitute.For<IMessageSender>();

		var sut = new WebApplicationFactory<Program>()
			.WithWebHostBuilder(builder => builder.ConfigureServices(collection =>
			{
				collection.Replace(ServiceDescriptor.Transient(_ => fakeMessageSender));
				collection.AddFakeNatsMessageQueue();
			}))
			.CreateClient();

		// Act
		_ = await sut
			.PostAsync(
				requestUri: "/api/tracker/trace",
				content: JsonContent.Create(JsonNode.Parse("""
				{
					"gameProviderId": "2c1ccb96-f58e-4b01-8a49-80922c9744cf",
					"walletId": "6e832d65-cabd-43ff-9f37-dc4cd616171c",
					"playerCode": "4ucmqplxb029"
				}
				""")))
			.ConfigureAwait(true);

		// Assert
		var data = JsonSerializer.SerializeToUtf8Bytes(new GameFundTraceMessage
		{
			GameProviderId = Guid.Parse("2c1ccb96-f58e-4b01-8a49-80922c9744cf"),
			WalletId = Guid.Parse("6e832d65-cabd-43ff-9f37-dc4cd616171c"),
			PlayerCode = "4ucmqplxb029"
		});
		_ = fakeMessageSender
			.Received(1)
			.PublishAsync(
				subject: Arg.Is(TrackerNatsConst.TracePublish),
				data: Arg.Is<byte[]>(raw => raw.SequenceEqual(data)),
				cancellationToken: Arg.Any<CancellationToken>());
	}
}
