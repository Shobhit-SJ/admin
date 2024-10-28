using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class AdminAction
{
    public int ActionId { get; set; }

    public int? AdminId { get; set; }

    public string? ActionType { get; set; }

    public string? Description { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual User? Admin { get; set; }
}
