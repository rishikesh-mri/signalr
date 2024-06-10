using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class UserDefinedApplication
{
    public string UserId { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public int EnvironmentId { get; set; }

    public virtual ClientTable Client { get; set; } = null!;

    public virtual Environment Environment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
