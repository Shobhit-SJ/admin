using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class PerformanceTracker
{
    public int TrackerId { get; set; }

    public int? ConsultantId { get; set; }

    public int? CompletedProjects { get; set; }

    public double? AverageRating { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Consultant? Consultant { get; set; }
}
