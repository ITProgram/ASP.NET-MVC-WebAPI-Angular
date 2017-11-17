using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public class ShopContext:DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Goods> Goods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}