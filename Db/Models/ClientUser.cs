using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientUser
{
    public int Id { get; set; }

    public string? ClientId { get; set; }

    public string? UserId { get; set; }

    public bool IsClientAdmin { get; set; }

    public bool? Dsc { get; set; }

    public bool? Dscplus { get; set; }

    public bool? ProductAdmin { get; set; }

    public virtual ICollection<CategoryClientUser> CategoryClientUsers { get; set; } = new List<CategoryClientUser>();

    public virtual ICollection<CategoryEnvironmentClientUser> CategoryEnvironmentClientUsers { get; set; } = new List<CategoryEnvironmentClientUser>();

    public virtual ClientTable? Client { get; set; }

    public virtual User? User { get; set; }
}
