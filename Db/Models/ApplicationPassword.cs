using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ApplicationPassword
{
    public int PasswordId { get; set; }

    public int ApplicationId { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? ActivateDate { get; set; }

    public DateTime? DeactivateDate { get; set; }

    public bool IsSuspended { get; set; }

    public string? SuspendedBy { get; set; }

    public string? SuspendReason { get; set; }

    public virtual Application Application { get; set; } = null!;
}
