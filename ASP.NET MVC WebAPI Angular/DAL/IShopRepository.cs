using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public interface IShopRepository:IDisposable
    {
        IEnumerable<Shop> GetShops( );
        Shop GetShopByID(int shopId);
        void InsertShop(Shop shop);
        void DeleteShop(int shopID);
        void UpdateShop(Shop shop);
        void Save();
    }
}