using System;
using System.Collections.Generic;

namespace AirlineAPI.Models;

public partial class FlightScheduleInfo
{
    public int FightId { get; set; }

    public string? Airline { get; set; }

    public string? SourceCity { get; set; }

    public string? Destination { get; set; }

    public string? AircraftType { get; set; }

    public virtual ICollection<BookingInfo> BookingInfos { get; set; } = new List<BookingInfo>();
}
