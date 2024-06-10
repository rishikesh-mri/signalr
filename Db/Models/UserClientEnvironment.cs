using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class UserClientEnvironment
{
    public string UserId { get; set; } = null!;

    public int ClientEnvironmentId { get; set; }

    public bool OffByAdmin { get; set; }

    public bool Off { get; set; }

    public virtual ClientEnvironment ClientEnvironment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
