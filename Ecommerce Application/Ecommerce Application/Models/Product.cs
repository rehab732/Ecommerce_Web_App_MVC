using System;
using System.Collections.Generic;

namespace Ecommerce_Application.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public int Catid { get; set; }

    public string Image { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category Cat { get; set; } = null!;
}
