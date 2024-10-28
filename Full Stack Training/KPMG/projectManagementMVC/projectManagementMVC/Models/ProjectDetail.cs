using System;
using System.Collections.Generic;

namespace projectManagementMVC.Models;

public partial class ProjectDetail
{
    public int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDomain { get; set; }

    public string? ProjectHead { get; set; }

    public string? ProjectLead { get; set; }

    public decimal? ProjectPrice { get; set; }

    public string? ProjectStatus { get; set; }
}
