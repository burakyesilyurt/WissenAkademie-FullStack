﻿using System;
using System.Collections.Generic;

namespace DBFirstCoreSample.Models;

public partial class CustomerTotal
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public double? CustomerTotal1 { get; set; }
}
