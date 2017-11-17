using ASP.NET_MVC_WebAPI_Angular.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_WebAPI_Angular.Controllers
{
    public class ShopController : Controller
    {
        private IShopRepository shopRepository;
        private IGoodsRepository goodsRepository;

        public ShopController()
        {
            this.shopRepository = new ShopRepository(new ShopContext());
            this.goodsRepository = new GoodsRepository(new ShopContext());
        }
        public ShopController(IShopRepository shopRepository, IGoodsRepository goodsRepository)
        {
            this.shopRepository = shopRepository;
            this.goodsRepository = goodsRepository;
        }
        //private ShopContext db = new ShopContext();
        public ActionResult Index()
        {
            return View(shopRepository.GetShops());
        }
        public ActionResult Goods()
        {
            return View(goodsRepository.GetGoods());
        }
        public ActionResult Shops()
        {
            return View(shopRepository.GetShops());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}