using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_WebAPI_Angular.Models
{
    public class Shop
    {
        public int ShopID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkingHours { get; set; }

        public virtual ICollection<Goods> Goods { get; set; }
    }
}