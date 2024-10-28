using System;
using System.Collections.Generic;

namespace productAPI.Models;

public partial class ProductList
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }
}
