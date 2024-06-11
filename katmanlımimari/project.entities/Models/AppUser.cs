using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.entities.Models
{
  public class AppUser : BaseEntity
  {
    public string UserName { get; set; }
    public string Password { get; set; }

    //relational properties 
    public virtual AppUserProfile AppUserProfile { get; set; }
    //Bir appuserin birden cok orderi olabilir
    public virtual List<Order> Orders { get; set; }

  }
}
