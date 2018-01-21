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
            var shoppingList = bearAndKittyHelper.GetAllDataForShopping();
            return View(shoppingList);
        }

        [HttpPost]
        public ActionResult AddItem(string name, int amount, string description)
        {
            bearAndKittyHelper.AddItemToShoppingList(name, amount, description);

            return RedirectToAction("Index");
        }

     
        public ActionResult DeleteItem(int id)
        {
            bearAndKittyHelper.DeleteItemFromShoppingList(id);
            return RedirectToAction("Index");
        }
    }
}