using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CategoryClientUser> CategoryClientUsers { get; set; } = new List<CategoryClientUser>();

    public virtual ICollection<CategoryEnvironmentClientUser> CategoryEnvironmentClientUsers { get; set; } = new List<CategoryEnvironmentClientUser>();
}
