using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public class GoodsRepository:IGoodsRepository, IDisposable
    {
        private ShopContext context;

        public GoodsRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<Goods> GetGoods()
        {
            return context.Goods.ToList();
        }

        public Goods GetGoodsByID(int id)
        {
            return context.Goods.Find(id);
        }

        public void InsertGoods(Goods Goods)
        {
            context.Goods.Add(Goods);
        }

        public void DeleteGoods(int goodsID)
        {
            Goods goods = context.Goods.Find(goodsID);
            context.Goods.Remove(goods);
        }

        public void UpdateGoods(Goods goods)
        {
            context.Entry(goods).State = EntityState.Modified;
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