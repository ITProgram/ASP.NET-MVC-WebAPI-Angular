using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public class UnitOfWork : IDisposable
    {
        private ShopContext context = new ShopContext();
        private GenericRepository<Shop> shopRepository;
        private GenericRepository<Goods> goodsRepository;

        public GenericRepository<Shop> ShopRepository
        {
            get
            {
                return this.shopRepository ?? new GenericRepository<Shop>(context);
            }
        }

        public GenericRepository<Goods> GoodsRepository
        {
            get
            {
                return this.goodsRepository ?? new GenericRepository<Goods>(context);
            }
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