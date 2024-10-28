using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class Consultant
{
    public int ConsultantId { get; set; }

    public int? UserId { get; set; }

    public string? ProfileInfo { get; set; }

    public double? Rating { get; set; }

    public int? TotalProjects { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<PerformanceTracker> PerformanceTrackers { get; set; } = new List<PerformanceTracker>();

    public virtual User? User { get; set; }
}
