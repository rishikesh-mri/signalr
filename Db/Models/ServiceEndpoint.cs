using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ServiceEndpoint
{
    public int ServiceEndpointId { get; set; }

    public int ServiceTypeId { get; set; }

    public int EnvironmentId { get; set; }

    public bool Active { get; set; }

    public string Url { get; set; } = null!;

    public virtual Environment Environment { get; set; } = null!;

    public virtual ServiceType ServiceType { get; set; } = null!;
}
