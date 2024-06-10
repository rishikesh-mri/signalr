using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientFeatureFlag
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public bool Available { get; set; }

    public bool? DefaultOn { get; set; }

    public string FeatureFlagId { get; set; } = null!;

    public virtual ClientTable Client { get; set; } = null!;

    public virtual FeatureFlag FeatureFlag { get; set; } = null!;
}
