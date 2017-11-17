using ASP.NET_MVC_WebAPI_Angular.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_MVC_WebAPI_Angular.Controllers
{
    [RoutePrefix("api/shops")]
    public class GoodsController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();   
        // GET: api/Goods
        [Route("{id:int}/goods")]
        [HttpGet]
        public IHttpActionResult GetGoodsByShopID(int id)
        {
            return Json(unitOfWork.GoodsRepository.Get().Where(g=>g.ShopID==id));
        }
    }
}
