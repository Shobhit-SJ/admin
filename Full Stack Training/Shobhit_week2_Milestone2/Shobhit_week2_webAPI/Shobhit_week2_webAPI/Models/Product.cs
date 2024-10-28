using System;
using System.Collections.Generic;

namespace Shobhit_week2_webAPI.Models;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public int? PPrice { get; set; }

    public int? PAvailableQty { get; set; }

    public string? PDescription { get; set; }

    public bool? PIsInStock { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
