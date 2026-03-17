using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class OrderStatus
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<OrderHistory> OrderHistories { get; set; } = new List<OrderHistory>();
}
