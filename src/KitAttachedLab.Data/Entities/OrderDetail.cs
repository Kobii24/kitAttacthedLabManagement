﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KitAttachedLab.Data.Entities;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? KitId { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? Quantity { get; set; }

    public string Description { get; set; }

    public decimal? Price { get; set; }

    public virtual Kit Kit { get; set; }

    public virtual Order Order { get; set; }
}