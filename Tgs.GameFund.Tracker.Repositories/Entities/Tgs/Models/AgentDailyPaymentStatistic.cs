using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentDailyPaymentStatistic
{
    public Guid AgentId { get; set; }

    public Guid BrandId { get; set; }

    public DateOnly ReportDate { get; set; }

    public int FirstDepositPlayers { get; set; }

    public int UndepositAgainPlayers { get; set; }

    public int DepositPlayers { get; set; }

    public decimal? DailyDepositAmount { get; set; }

    public decimal? DailyDepositHandlingFee { get; set; }

    public decimal? DailyWithdrawAmount { get; set; }

    public decimal? DailyWithdrawHandlingFee { get; set; }
}
