using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chocolate.Models;


namespace model_controller_assignment.Controllers
{
    public class ChocolateController : Controller
    {
        public async Chocolate<IActionResult> Index()
        {
            var items = await _ChocolateItemService.GetIncompleteItemsAsync();
            var model = new ChocolateModel()
            {
                Items = items
            };
            return View(model);
        }
    }
}