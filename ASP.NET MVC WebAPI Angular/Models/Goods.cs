using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.Models
{
    public class Goods
    {
        public int GoodsID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public int ShopID { get; set; }
        //public virtual Shop Shop { get; set; }
    }
}