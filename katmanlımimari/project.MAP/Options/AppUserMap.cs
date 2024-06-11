using project.entities.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MAP.Options
{
  public class AppUserMap : BaseMap<AppUser>
  {
    public AppUserMap()
    {
      ToTable("Kullanıcılar");
      Property(x => x.UserName).HasColumnName("Kullanıcı İsmi");
      Property(x => x.Password).HasColumnName("Şifre");
      HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser); //1e1 ilişkiyi tamamladık.


    }
  }
}
