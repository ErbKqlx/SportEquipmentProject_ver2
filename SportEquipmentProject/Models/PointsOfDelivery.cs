using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class PointsOfDelivery
{
    public int Id { get; set; }

    public string PointName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<OrderHistory> OrderHistories { get; set; } = new List<OrderHistory>();
}
