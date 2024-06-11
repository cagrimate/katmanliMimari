using project.entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MAP.Options
{
  public class OrderMap : BaseMap<Order>
  {
    public OrderMap()
    {
      ToTable("Siparişler");
      Property(x => x.ShippedAddress).HasColumnName("Teslim Adresi");

    }
  }
}
