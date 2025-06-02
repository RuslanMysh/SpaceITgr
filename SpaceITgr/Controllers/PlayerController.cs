using Microsoft.AspNetCore.Mvc;
using SpaceITgr.Models;
using System;
using System.Linq;

namespace SpaceITgr.Controllers
{
	[Route("Player")]
	public class PlayerController : Controller
	{
		[HttpGet("PlayerPlanets")]
        public JsonResult PlayerPlanets()
		{
            var planetsList = SpaceData.Planets.Select(p => new
            {
                Id = p.Key,
                Name = p.Value.LocalName, 
                Type = p.Value.PlanetType.ToString(),
                Studied = p.Value.StudiedByPlayer
            }).ToArray();

            return Json(planetsList);
		}

		[HttpGet("PlayerQuests")]
		public JsonResult PlayerQuests()
		{
			var QuestsList = SpaceData.Quests.Select(p => new
			{
				Id = p.Key,
				Name = p.Value.Name,
				Type = p.Value.QuestType.ToString(),
                Desc = p.Value.Description,
                Date = p.Value.DateOfAppointment.ToString()

            }).ToArray();

			return Json(QuestsList);
		}

        [HttpGet("PlayerInventory")]
        public JsonResult PlayerInventory()
        {
            var InventoryList = SpaceData.Inventory.Select(p => new
            {
                Name = p.Name,
                Mass = p.Mass,
                Count = p.Count

            }).ToArray();

            return Json(InventoryList);
        }

        [HttpPost("AddItemToInventory")]
        public async Task<IActionResult> AddItemToInventory()
        {
            var item = await Request.ReadFromJsonAsync<Item>();
            Console.WriteLine($"Adding item: Name={item.Name}, Count={item.Count}, Mass={item.Mass}");
            SpaceData.Inventory.Add(item);
            Console.WriteLine($"Inventory now has {SpaceData.Inventory.Count} items");
            return Json(new { success = true, message = "Предмет добавлен!" });
        }
    }
}
