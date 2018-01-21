using ProjectBearAndKitty.Models;
using ProjectBearAndKitty.Migrations;
using System.Linq;
using System.Collections.Generic;

namespace ProjectBearAndKitty.Helpers
{
    public class BearAndKittyHelper
    {
        public BearAndKittyHelper()
        {

        }
        public List<ShoppingList> GetAllDataForShopping()
        {
            using(var db =new BearAndKitty())
            {
                var shoppingLists = (from s in db.ShoppingLists
                             select s).ToList();
                return shoppingLists;
            }
        }
        public void AddItemToShoppingList(string nameOfProduct, int amount = 1, string description = "")
        {
           using (var db = new BearAndKitty())
            {
                var shoppingList = new ShoppingList()
                {
                    Amount = amount,
                    Description = description,
                    NameOfProduct = nameOfProduct
                };
                db.ShoppingLists.Add(shoppingList);
                db.SaveChanges();
            }
        }
        public void DeleteItemFromShoppingList(int id)
        {
            using (var db = new BearAndKitty())
            {
                var shoppingListToRemove = (from s in db.ShoppingLists
                                     where s.Id == id
                                     select s).SingleOrDefault();
                db.ShoppingLists.Remove(shoppingListToRemove);
                db.SaveChanges();
            }
        }
    }
}