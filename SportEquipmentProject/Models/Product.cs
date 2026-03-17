using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class Product
{
    public long Id { get; set; }

    public string Article { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public short IdProductCategory { get; set; }

    public int IdManufacturer { get; set; }

    public int IdSupplier { get; set; }

    public decimal Price { get; set; }

    public short IdUnitOfMeasurement { get; set; }

    public short Discount { get; set; }

    public short Count { get; set; }

    public string Description { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual ProductCategory IdProductCategoryNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitsOfMeasurement IdUnitOfMeasurementNavigation { get; set; } = null!;

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();
}
