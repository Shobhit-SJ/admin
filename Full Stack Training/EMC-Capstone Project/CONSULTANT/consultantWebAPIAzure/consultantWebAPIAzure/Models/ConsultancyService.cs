using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class ConsultancyService
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }
}
