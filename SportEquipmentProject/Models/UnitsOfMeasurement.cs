using System;
using System.Collections.Generic;

namespace SportEquipmentProject.Models;

public partial class UnitsOfMeasurement
{
    public short Id { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
