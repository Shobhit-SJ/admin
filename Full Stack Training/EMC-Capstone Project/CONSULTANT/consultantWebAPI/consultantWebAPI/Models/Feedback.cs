﻿using System;
using System.Collections.Generic;

namespace consultantWebAPI.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public int? AppointmentId { get; set; }

    public int? Rating { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Appointment? Appointment { get; set; }
}
