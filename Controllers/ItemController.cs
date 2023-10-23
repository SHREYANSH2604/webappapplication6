using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppApplication.Models;


namespace WebAppApplication.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            
            var items = new List<Item>
            {
                new Item { Id = 1, Name = "Item 1", Price = 10.99 },
                new Item { Id = 2, Name = "Item 2", Price = 19.99 },
                new Item { Id = 3, Name = "Item 3", Price = 5.99 },
                new Item { Id = 4, Name = "Item 4", Price = 26.99 },
                new Item { Id = 5, Name = "Item 5", Price = 18.99 },
                new Item { Id = 6, Name = "Item 6", Price = 14.99 },
                new Item { Id = 7, Name = "Item 7", Price = 7.99 }
            };

            return View(items);
        }
    }
}
