using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ServiceType
{
    public int ServiceTypeId { get; set; }

    public string ServiceTypeName { get; set; } = null!;

    public virtual ICollection<ServiceEndpoint> ServiceEndpoints { get; set; } = new List<ServiceEndpoint>();
}
