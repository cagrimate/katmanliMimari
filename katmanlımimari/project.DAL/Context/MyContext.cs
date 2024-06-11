using project.entities.Models;
using project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Context
{
  public class MyContext : DbContext
  {
    //optionsBuilder.UseSqlServer("Server=CAGRI; Database=HotelDb;uid=sa;pwd=123456789;TrustServerCertificate=true");

    public MyContext(): base("DefaultConnection")
    {

    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new AppUserMap());
      modelBuilder.Configurations.Add(new OrderMap());
      modelBuilder.Configurations.Add(new ProductMap());
      modelBuilder.Configurations.Add(new OrderDetailMap());
      modelBuilder.Configurations.Add(new AppUserProfileMap());
      modelBuilder.Configurations.Add(new CategoryMap());
      modelBuilder.Configurations.Add(new ShipperMap());
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserProfile> AUserProfiles { get; set; }
  }
}
