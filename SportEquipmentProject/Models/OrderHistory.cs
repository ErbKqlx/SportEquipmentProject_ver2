using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class OrderHistory
{
    public long Id { get; set; }

    public string OrderArticle { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public int IdPointOfDelivery { get; set; }

    public long IdUser { get; set; }

    public string Code { get; set; } = null!;

    public short IdStatus { get; set; }

    public virtual PointsOfDelivery IdPointOfDeliveryNavigation { get; set; } = null!;

    public virtual OrderStatus IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();
}
