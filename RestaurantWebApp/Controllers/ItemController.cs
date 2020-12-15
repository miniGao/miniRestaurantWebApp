using Microsoft.AspNetCore.Mvc;
using RestaurantWebApp.Models;
using RestaurantWebApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository itemRepo;
        private int itemPerPage = 3;

        public ItemController(IItemRepository repo)
        {
            itemRepo = repo;
        }

        public IActionResult Index(int itemPage = 1)
        {
            //// pagination
            //return View(
            //    itemRepo.Items.OrderBy(i => i.ItemId)
            //    .Skip((itemPage - 1) * itemPerPage)
            //    .Take(itemPerPage)
            //    );

            return View(
                new ItemListViewModel
                {
                    Items = itemRepo.Items.OrderBy(i => i.ItemId)
                    .Skip((itemPage - 1) * itemPerPage)
                    .Take(itemPerPage),

                    PageInfo = new ItemPerPage
                    {
                        CurrentPage = itemPage,
                        ItemsPerPage = itemPerPage,
                        TotalItems = itemRepo.Items.Count()
                    }
                }
                );
        }
    }
}
