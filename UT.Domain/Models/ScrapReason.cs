﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace UT.Domain.Models;

/// <summary>
/// Manufacturing failure reasons lookup table.
/// </summary>
public partial class ScrapReason
{
    /// <summary>
    /// Primary key for ScrapReason records.
    /// </summary>
    public short ScrapReasonId { get; set; }

    /// <summary>
    /// Failure description.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}