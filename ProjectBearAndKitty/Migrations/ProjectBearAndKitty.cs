using ProjectBearAndKitty.Models;
using System.Data.Entity;

namespace ProjectBearAndKitty.Migrations
{
    public class ProjectBearAndKitty : DbContext
    {
            public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}