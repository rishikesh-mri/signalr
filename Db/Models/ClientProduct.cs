using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientProduct
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public int ProductId { get; set; }

    public bool IsOnPrem { get; set; }

    public virtual ClientTable Client { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
