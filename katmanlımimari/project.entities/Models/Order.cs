using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.entities.Models
{
  public class Order : BaseEntity
  {
    public string ShippedAddress { get; set; }
    public int? AppUserID { get; set; }
    public int ShipperID { get; set; }
    //relational properties
    //app user ile ilişkisi varr bir siparis 1 kisinindir
    public virtual AppUser AppUser { get; set; }
    public virtual List<OrderDetail> OrderDetail { get; set; }
    public virtual Shipper Shipper { get; set; }

  }
}
