using Microsoft.AspNetCore.Mvc;
using RestaurantWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Components
{
    public class NavMenuViewComponent : ViewComponent
    {
        private IItemRepository repo;

        public NavMenuViewComponent(IItemRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            // highlight current category
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(
                repo.Items
                .Select(i => i.ItemCategory)
                .Distinct()
                .OrderBy(i => i)
                );
        }
    }
}
