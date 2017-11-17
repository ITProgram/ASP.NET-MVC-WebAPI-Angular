using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ASP.NET_MVC_WebAPI_Angular.DAL;
using ASP.NET_MVC_WebAPI_Angular.Models;

namespace ASP.NET_MVC_WebAPI_Angular.Controllers
{
    [RoutePrefix("api/shops")]
    public class ShopsController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        //GET: api/shops
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetShops()
        {
            return Json(unitOfWork.ShopRepository.Get());
        }

        // GET: api/shops/5
        [Route("{id:int}")]
        [HttpGet]
        public IHttpActionResult GetShopByID(int id)
        {
            Shop shop = unitOfWork.ShopRepository.GetByID(id);
            if (shop == null)
            {
                return NotFound();
            }
            return Json(shop);
        }
    }
}