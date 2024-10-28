using System;
using System.Collections.Generic;

namespace firstWebApp.Model;

public partial class Friend
{
    public int FriendId { get; set; }

    public string? FriendName { get; set; }

    public long? FriendMobile { get; set; }

    public string? FriendEmail { get; set; }

    public string? FriendType { get; set; }

    public bool? SeriousFriend { get; set; }
}
