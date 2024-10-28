using System;
using System.Collections.Generic;

namespace AirlineAPI.Models;

public partial class PassengerInfo
{
    public int PassengerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? Panno { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
