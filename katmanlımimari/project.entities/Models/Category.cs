using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.entities.Models
{
  public class Category : BaseEntity
  {
    public string CategoryName { get; set; }

    public string Description { get; set; }

    //relational properties product ile

    public virtual List<Product> Products { get; set; }

  }
}
