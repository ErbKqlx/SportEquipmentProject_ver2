using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class ProductCategory
{
    public short Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
