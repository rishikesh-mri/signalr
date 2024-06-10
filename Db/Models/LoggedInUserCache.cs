using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class LoggedInUserCache
{
    public string UserId { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string? FederatedIdentityProvider { get; set; }
}
