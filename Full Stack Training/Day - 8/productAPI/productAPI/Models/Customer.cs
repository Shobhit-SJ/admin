using System;
using System.Collections.Generic;

namespace productAPI.Models;

public partial class Customer
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public int? CBalance { get; set; }

    public string? CAddress { get; set; }
}
