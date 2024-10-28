using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? ConsultantId { get; set; }

    public int? ClientId { get; set; }

    public DateTime ScheduledTime { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Consultant? Consultant { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
}
