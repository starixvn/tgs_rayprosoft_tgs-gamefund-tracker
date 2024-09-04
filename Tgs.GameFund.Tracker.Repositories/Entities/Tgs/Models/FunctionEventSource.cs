using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class FunctionEventSource
{
    public Guid Id { get; set; }

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid FunctionId { get; set; }

    public string System { get; set; } = null!;

    public virtual Function Function { get; set; } = null!;

    public virtual System SystemNavigation { get; set; } = null!;
}
