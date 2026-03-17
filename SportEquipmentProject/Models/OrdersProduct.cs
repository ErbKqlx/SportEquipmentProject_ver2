using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class OrdersProduct
{
    public long Id { get; set; }

    public long IdOrder { get; set; }

    public long IdProduct { get; set; }

    public int Count { get; set; }

    public virtual OrderHistory IdOrderNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
