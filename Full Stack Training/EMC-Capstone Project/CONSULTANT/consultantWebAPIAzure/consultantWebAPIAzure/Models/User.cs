using System;
using System.Collections.Generic;

namespace consultantWebAPIAzure.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long PhoneNum { get; set; }

    public string UserEmailId { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string? UserRole { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AdminAction> AdminActions { get; set; } = new List<AdminAction>();

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Consultant> Consultants { get; set; } = new List<Consultant>();
}
