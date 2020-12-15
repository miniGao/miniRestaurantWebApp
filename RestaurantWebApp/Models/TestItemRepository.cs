using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public class TestItemRepository : IItemRepository
    {
        public IQueryable<Item> Items => new List<Item>
        {
            new Item {ItemName="Value Box", ItemPrice = 9.00M},
            new Item {ItemName="Meal for 2", ItemPrice = 16.00M},
            new Item {ItemName="Fries Supreme", ItemPrice = 4.89M}
        }.AsQueryable<Item>();
    }
}
