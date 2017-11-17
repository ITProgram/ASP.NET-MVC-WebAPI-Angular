using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
//    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseAlways<ShopContext>

    {
        protected override void Seed(ShopContext context)
        {
            var shops = new List<Shop>
            {
            new Shop{ShopID=1, Name="Shop 1", Address="shop 1 address", WorkingHours="c 10:00 до 24:00" },
            new Shop{ShopID=2, Name="Shop 2", Address="shop 2 address", WorkingHours="c 10:00 до 24:00" },
            new Shop{ShopID=3, Name="Shop 3", Address="shop 3 address", WorkingHours="c 10:00 до 24:00" },
            new Shop{ShopID=4, Name="Shop 4", Address="shop 4 address", WorkingHours="c 10:00 до 24:00" },
            new Shop{ShopID=5, Name="Shop 5", Address="shop 5 address", WorkingHours="c 10:00 до 24:00" },
            };
            shops.ForEach(s => context.Shops.Add(s));
            context.SaveChanges();

            var goods = new List<Goods>
            {
            new Goods{GoodsID=1, Name="goods1",Description="description for goods 1",ShopID=1},
            new Goods{GoodsID=2, Name="goods2",Description="description for goods 2",ShopID=1},
            new Goods{GoodsID=3, Name="goods3",Description="description for goods 3",ShopID=1},
            new Goods{GoodsID=4, Name="goods4",Description="description for goods 4",ShopID=2},
            new Goods{GoodsID=5, Name="goods5",Description="description for goods 5",ShopID=2},
            new Goods{GoodsID=6, Name="goods6",Description="description for goods 6",ShopID=2},
            new Goods{GoodsID=7, Name="goods7",Description="description for goods 7",ShopID=3},
            new Goods{GoodsID=8, Name="goods8",Description="description for goods 8",ShopID=3},
            new Goods{GoodsID=9, Name="goods9",Description="description for goods 9",ShopID=3},
            //new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            goods.ForEach(s => context.Goods.Add(s));
            context.SaveChanges();
            
        }

    }
}