using ASP.NET_MVC_WebAPI_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.DAL
{
    public interface IGoodsRepository:IDisposable
    {
        IEnumerable<Goods> GetGoods( );
        Goods GetGoodsByID(int goodsId);
        void InsertGoods(Goods goods);
        void DeleteGoods(int goodsID);
        void UpdateGoods(Goods goods);
        void Save();
    }
}