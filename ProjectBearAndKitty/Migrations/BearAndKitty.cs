using ProjectBearAndKitty.Models;
using System.Data.Entity;

namespace ProjectBearAndKitty.Migrations
{
    public class BearAndKitty : DbContext
    {
        public BearAndKitty(): base("name=BearAndKitty") {}

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}