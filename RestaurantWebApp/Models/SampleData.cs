using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Models
{
    public static class SampleData
    {
        public static void PopulateSampleData(IApplicationBuilder app)
        {
            RestaurantDbContext context = app.ApplicationServices
                .GetRequiredService<RestaurantDbContext>();
            context.Database.Migrate();
            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    {
                        ItemName = "2 Chicken Soft Tacos Combo",
                        ItemCategory = "Combos",
                        ItemPrice = 9.59M,
                        ItemDescription = "660-950 cal. A soft flour tortilla filled with grilled chicken, lettuce, pico de gallo, and cheddar cheese. Plus regular fries and a drink."
                    },
                    new Item
                    {
                        ItemName = "2 Steak Soft Tacos Combo",
                        ItemCategory = "Combos",
                        ItemPrice = 9.59M,
                        ItemDescription = "660-950 cal. A soft flour tortilla filled with grilled steak, spicy ranch sauce, lettuce, cheddar cheese, and tomatoes. Plus regular fries and a drink."
                    },
                    new Item
                    {
                        ItemName = "Burrito Supreme® Combo",
                        ItemCategory = "Combos",
                        ItemPrice = 9.99M,
                        ItemDescription = "700-1030 cal. A soft flour tortilla filled with seasoned beef, re-fried beans, red sauce, lettuce, cheddar cheese, onions, tomatoes, and reduced-fat sour cream. Plus regular fries and a 20oz drink."
                    },
                    new Item
                    {
                        ItemName = "Value Box",
                        ItemCategory = "Value Combos",
                        ItemPrice = 9.00M,
                        ItemDescription = "1280-1590 cal. Includes a chalupa supreme, beef crunchy taco, beef burrito, regular fries, and a 20oz drink."
                    },
                    new Item
                    {
                        ItemName = "Meal for 2",
                        ItemCategory = "Value Combos",
                        ItemPrice = 16.00M,
                        ItemDescription = "970-1330 cal. per serving. Includes two beef crunchy tacos, two regular fries, two 20oz drinks, and a choice of two crunchwrap supremes or two cheesy gordita crunch or one of each."
                    },
                    new Item
                    {
                        ItemName = "$25 Variety Pack",
                        ItemCategory = "Value Combos",
                        ItemPrice = 25.00M,
                        ItemDescription = "570 cal. per serving. Includes four beef crunchy tacos, four beef burritos, two fries supreme, and two cinnamon twists. Serves six."
                    },
                    new Item
                    {
                        ItemName = "Crunchy Tacos Party Pack",
                        ItemCategory = "Party Pack",
                        ItemPrice = 26.59M,
                        ItemDescription = "550 cal. per serving. 10 crunchy tacos, two regular fries, and two chips and nacho cheese sauce. Serves five."
                    },
                    new Item
                    {
                        ItemName = "Doritos Tacos Party Pack",
                        ItemCategory = "Party Pack",
                        ItemPrice = 29.09M,
                        ItemDescription = "540 cal. per serving. 10 Doritos® Locos Tacos, two regular fries, and two chips, and nacho cheese sauce. Serves five."
                    },
                    new Item
                    {
                        ItemName = "Supreme® Tacos Party Pack",
                        ItemCategory = "Party Pack",
                        ItemPrice = 29.59M,
                        ItemDescription = "600 cal. per serving. 10 Crunchy Tacos Supreme®, two regular fries, and two chips and nacho cheese sauce. Serves five."
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
