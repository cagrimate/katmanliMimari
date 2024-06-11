using project.entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MAP.Options
{
  public class OrderDetailMap : BaseMap<OrderDetail>
  {
    public OrderDetailMap()
    {
      ToTable("Satışlar");
      Ignore(x => x.Id);
      HasKey(x => new
      {
        x.OrderID,
        x.ProductID
      });
    }
  }
}
