using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class IdentityPolicy
{
    public string PolicyId { get; set; } = null!;

    public string? PolicyName { get; set; }

    public string? PolicyType { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ClientTable> ClientTableOktaMfaPolicies { get; set; } = new List<ClientTable>();

    public virtual ICollection<ClientTable> ClientTableOktaPasswordPolicies { get; set; } = new List<ClientTable>();

    public virtual ICollection<ClientTable> ClientTableOktaSignOnPolicies { get; set; } = new List<ClientTable>();
}
