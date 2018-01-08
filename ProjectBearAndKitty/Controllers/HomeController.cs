using ProjectBearAndKitty.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectBearAndKitty.Controllers
{
    public class HomeController : Controller
    {
        BearAndKittyHelper bearAndKittyHelper = new BearAndKittyHelper();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          
            var shoppingList = bearAndKittyHelper.GetAllDataForShopping();
             
            foreach (var item in shoppingList)
            {
                ViewBag.Message += item.NameOfProduct + "<br/>";
            }
            return View();
        }

        public ActionResult Contact()
        {
            bearAndKittyHelper.AddItemToShoppingList("jammy jam jam");
            ViewBag.Message = "Your added jammy jam jam.";
            return View();
        }
    }
}