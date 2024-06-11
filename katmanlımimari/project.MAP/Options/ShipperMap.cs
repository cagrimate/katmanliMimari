using project.entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MAP.Options
{
  public class ShipperMap : BaseMap<Shipper>
  {
    public ShipperMap()
    {
      ToTable("Kargocular");
      Property(x => x.CompanyName).HasColumnName("Şirket İsmi");


    }
  }
}
