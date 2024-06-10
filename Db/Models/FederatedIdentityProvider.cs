using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class FederatedIdentityProvider
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public string ProviderId { get; set; } = null!;

    public string? NavigationHint { get; set; }

    public string? Usage { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ClientTable Client { get; set; } = null!;

    public virtual ICollection<ClientDomain> ClientDomains { get; set; } = new List<ClientDomain>();
}
