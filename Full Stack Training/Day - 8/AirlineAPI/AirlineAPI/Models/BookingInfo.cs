using System;
using System.Collections.Generic;

namespace AirlineAPI.Models;

public partial class BookingInfo
{
    public int Pnrno { get; set; }

    public int? PassengerId { get; set; }

    public int? FlightId { get; set; }

    public DateTime? FlightDate { get; set; }

    public string? FlightStatus { get; set; }

    public virtual FlightScheduleInfo? Flight { get; set; }
}
