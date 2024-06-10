using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public string ApplicationName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ApplicationPassword> ApplicationPasswords { get; set; } = new List<ApplicationPassword>();
}
