using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public int? UserId { get; set; }

    public decimal? WalletBalance { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User? User { get; set; }
}
