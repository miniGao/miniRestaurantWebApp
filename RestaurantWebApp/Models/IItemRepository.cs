using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public interface IItemRepository
    {
        IQueryable<Item> Items { get; }
    }
}
