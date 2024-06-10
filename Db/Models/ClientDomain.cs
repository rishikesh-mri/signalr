using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientDomain
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public string Domain { get; set; } = null!;

    public virtual ClientTable Client { get; set; } = null!;

    public virtual ICollection<FederatedIdentityProvider> FederatedIdentityProviders { get; set; } = new List<FederatedIdentityProvider>();
}
