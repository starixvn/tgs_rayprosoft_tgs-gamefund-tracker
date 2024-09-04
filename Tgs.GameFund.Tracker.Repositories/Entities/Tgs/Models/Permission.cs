using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Permission
{
    public Guid Id { get; set; }

    public string Action { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid FunctionId { get; set; }

    public string Identity { get; set; } = null!;

    public string IdentityType { get; set; } = null!;

    public int Order { get; set; }

    public string System { get; set; } = null!;

    public Guid FkFunctions { get; set; }

    public virtual Function FkFunctionsNavigation { get; set; } = null!;

    public virtual System SystemNavigation { get; set; } = null!;
}
