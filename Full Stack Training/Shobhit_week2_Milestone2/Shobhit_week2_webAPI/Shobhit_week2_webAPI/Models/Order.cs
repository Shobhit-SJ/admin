using System;
using System.Collections.Generic;

namespace Shobhit_week2_webAPI.Models;

public partial class Order
{
    public int OId { get; set; }

    public int? CId { get; set; }

    public int? PId { get; set; }

    public string? OStatus { get; set; }

    public virtual Customer? CIdNavigation { get; set; }

    public virtual Product? PIdNavigation { get; set; }
}
