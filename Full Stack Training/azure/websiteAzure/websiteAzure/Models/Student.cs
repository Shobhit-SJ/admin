﻿using System;
using System.Collections.Generic;

namespace websiteAzure.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int DepartmentId { get; set; }
}
