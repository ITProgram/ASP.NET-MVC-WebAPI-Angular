using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public class ShopRepository:IShopRepository, IDisposable
    {
        private ShopContext context;

        public ShopRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<Shop> GetShops()
        {
            return context.Shops.ToList();
        }

        public Shop GetShopByID(int id)
        {
            return context.Shops.Find(id);
        }

        public void InsertShop(Shop shop)
        {
            context.Shops.Add(shop);
        }

        public void DeleteShop(int shopID)
        {
            Shop shop = context.Shops.Find(shopID);
            context.Shops.Remove(shop);
        }

        public void UpdateShop(Shop shop)
        {
            context.Entry(shop).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}