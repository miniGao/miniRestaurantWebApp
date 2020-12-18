using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public class Cart
    {
        private List<CartRecord> cartRecords = new List<CartRecord>();

        public virtual void AddItem(Item item, int quantity)
        {
            CartRecord record = cartRecords
                .Where(r => r.Item.ItemId == item.ItemId)
                .FirstOrDefault();

            if (record == null)
            {
                cartRecords.Add(new CartRecord
                {
                    Item = item,
                    Quantity = quantity
                });
            }
            else
            {
                record.Quantity += quantity;
            }
        }

        public virtual IEnumerable<CartRecord> Records => cartRecords;
        public virtual void ClearCart()
        {
            cartRecords.Clear();
        }
        public virtual decimal GetTotalPrice()
        {
            return cartRecords.Sum(r => r.Item.ItemPrice * r.Quantity);
        }
        public virtual void RemoveRecord(Item item)
        {
            cartRecords.RemoveAll(r => r.Item.ItemId == item.ItemId);
        }
    }
}
