using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class CategoryEnvironmentClientUser
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int EnvironmentId { get; set; }

    public int ClientUserId { get; set; }

    public int SortOrder { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ClientUser ClientUser { get; set; } = null!;

    public virtual Environment Environment { get; set; } = null!;
}
