using Microsoft.AspNetCore.Mvc;
using RestaurantWebApp.Infrastructure;
using RestaurantWebApp.Models;
using RestaurantWebApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Controllers
{
    public class CartController : Controller
    {
        private IItemRepository repo;

        public CartController(IItemRepository _repo)
        {
            repo = _repo;
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        public IActionResult AddToCart(int itemId, string returnUrl)
        {
            Item item = repo.Items.FirstOrDefault(i => i.ItemId == itemId);
            if (item != null)
            {
                Cart cart = GetCart();
                cart.AddItem(item, 1);
                SaveCart(cart);
            }
            return RedirectToAction("CartSummary", new { returnUrl });
        }

        public IActionResult RemoveFromCart (int itemId, string returnUrl)
        {
            Item item = repo.Items.FirstOrDefault(i => i.ItemId == itemId);
            if(item != null)
            {
                Cart cart = GetCart();
                cart.RemoveRecord(item);
                SaveCart(cart);
            }
            return RedirectToAction("CartSummary", new { returnUrl });
        }

        public IActionResult CartSummary(string returnUrl)
        {
            return View(new CartSummaryViewModel { Cart = GetCart(), ReturnUrl = returnUrl });
        }
    }
}
