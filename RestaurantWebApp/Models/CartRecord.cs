using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public class CartRecord
    {
        public int CartRecordId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
