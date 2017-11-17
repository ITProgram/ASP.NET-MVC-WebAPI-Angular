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
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            return View(unitOfWork.ShopRepository.Get());
        }
        public ActionResult Goods()
        {
            return View(unitOfWork.GoodsRepository.Get());
        }
        public ActionResult Shops()
        {
            return View(unitOfWork.ShopRepository.Get());
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