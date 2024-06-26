﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.entities.Models
{
  public class Product : BaseEntity
  {
    public string ProductName { get; set; }

    public decimal UnitPrice { get; set; }
    public int? CategoryID { get; set; }

    //relational Properties
    public virtual Category Category { get; set; }

    public virtual List<OrderDetail> OrderDetails { get; set; }

  }
}
