using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tgs.GameFund.Tracker.Core;

public record class GameFundTraceMessage
{
	[Required]
	[DefaultValue(typeof(Guid), "2c1ccb96-f58e-4b01-8a49-80922c9744cf")]
	public Guid GameProviderId { get; init; } = default!;

	[Required]
	[DefaultValue(typeof(Guid), "6e832d65-cabd-43ff-9f37-dc4cd616171c")]
	public Guid WalletId { get; init; } = default!;

	[Required]
	[DefaultValue(typeof(string), "4ucmqplxb029")]
	public string PlayerCode { get; init; } = default!;
}
