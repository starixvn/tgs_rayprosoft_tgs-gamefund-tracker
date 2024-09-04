using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Tgs.GameFund.Tracker.Core;
using Valhalla.MessageQueue;

namespace Tgs.GameFund.Tracker.Controllers;

[Route("[controller]")]
[ApiController]
public class TrackerController : ControllerBase
{
	[HttpPost("trace")]
	public ValueTask TraceGameFundAsync(
		[FromServices] IMessageSender messageSender,
		GameFundTraceMessage source)
		=> messageSender.PublishAsync(
			subject: TrackerNatsConst.TracePublish,
			data: JsonSerializer.SerializeToUtf8Bytes(source),
			cancellationToken: HttpContext.RequestAborted);

}
