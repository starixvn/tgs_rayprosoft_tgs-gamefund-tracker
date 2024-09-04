using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerAuthenticationForm
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Data { get; set; } = null!;

    public string PlayerCode { get; set; } = null!;

    public DateTime? ReviewedOn { get; set; }

    public string? ReviewedUserId { get; set; }

    public string? ReviewedUserName { get; set; }

    public int Status { get; set; }

    public string? Remark { get; set; }
}
