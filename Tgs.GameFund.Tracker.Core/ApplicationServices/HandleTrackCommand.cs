namespace Tgs.GameFund.Tracker.Core.ApplicationServices;

public record class HandleTrackCommand(
    Guid GameProviderId,
    Guid WalletId,
    string PlayerCode);
