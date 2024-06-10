using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientEnvironment
{
    public int ClientEnvironmentId { get; set; }

    public string ClientId { get; set; } = null!;

    public int EnvironmentId { get; set; }

    public bool IsDefault { get; set; }

    public string? ForceIdentityProviderId { get; set; }

    public virtual ClientTable Client { get; set; } = null!;

    public virtual Environment Environment { get; set; } = null!;

    public virtual ICollection<UserClientEnvironment> UserClientEnvironments { get; set; } = new List<UserClientEnvironment>();
}
