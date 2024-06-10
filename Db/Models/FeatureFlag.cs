using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class FeatureFlag
{
    public string Id { get; set; } = null!;

    public bool Available { get; set; }

    public bool DefaultOn { get; set; }

    public virtual ICollection<ClientFeatureFlag> ClientFeatureFlags { get; set; } = new List<ClientFeatureFlag>();

    public virtual ICollection<UserFeatureFlag> UserFeatureFlags { get; set; } = new List<UserFeatureFlag>();
}
