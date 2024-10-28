using System;
using System.Collections.Generic;

namespace Shobhit_week2_webAPI.Models;

public partial class Customer
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CAddress { get; set; }

    public int? CWalletBalance { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
