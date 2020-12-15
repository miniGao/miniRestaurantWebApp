using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public class ItemRepository : IItemRepository
    {
        private RestaurantDbContext context;
        public ItemRepository(RestaurantDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Item> Items => context.Items;
    }
}
