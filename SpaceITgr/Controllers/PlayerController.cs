using Microsoft.AspNetCore.Mvc;
using SpaceITgr.Models;
using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
			var QuestsList = SpaceData.Quests.Select(q => new
			{
				Name = q.Name,
				Type = q.QuestType.ToString(),
                Desc = q.Description,
                Date = q.DateOfAppointment

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
            return Json(new { message = "Предмет добавлен!" });
        }

        [HttpPost("AddQuest")]
        public async Task<IActionResult> AddQuest()
        {  
            try
            {
                var quest = await Request.ReadFromJsonAsync<Quest>();
                if (quest == null)
                {
                    return BadRequest(new { success = false, message = "Invalid data" });                                      
                }
                var newQuest = new Quest(
                        Name: quest.Name,
                        Description: quest.Description,
                        DateOfAppointment: quest.DateOfAppointment,
                        QuestType: QuestType.Current
                );
                SpaceData.Quests.Add(newQuest); 
                Console.WriteLine($"Adding quest {newQuest.Name} {newQuest.QuestType}");
                return Json(new { message = "Квест добавлен!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding quest: {ex.Message}");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        [HttpPost("ChangePlanet")]
        public async Task<IActionResult> ChangePlanet()
        {
            var planet = await Request.ReadFromJsonAsync<Planet>();
            Console.WriteLine(planet.CodeName, planet.StudiedByPlayer);
            SpaceData.Planets[175].StudiedByPlayer = planet.StudiedByPlayer;
            return Json(planet);
        }
        [HttpPost("ChangeQuest")]
        public async Task<IActionResult> ChangeQuest([FromBody] Quest quest)
        {
            Console.WriteLine(quest.Name, quest.Description, quest.QuestType);
            var questFind = SpaceData.Quests.Find(x => x.Name == "Спасибо Маску За Грок!");
            questFind.QuestType = quest.QuestType;
            Console.WriteLine($"{questFind.QuestType}");
            return Json(questFind);
        }
        [HttpPost("RemoveItem")]
        public async Task<IActionResult> RemoveItem()
        {


            if (SpaceData.Inventory.Exists(x => x.Name == "Грок"))
            {
                var invFind = SpaceData.Inventory.Find(x => x.Name == "Грок");
                Console.WriteLine(invFind);
                SpaceData.Inventory.Remove(invFind);
                return Json(invFind);
            }
            else if (SpaceData.Inventory.Exists(x => x.Name == "Копия ключа от подвала"))
            {
                var invFind = SpaceData.Inventory.Find(x => x.Name == "Копия ключа от подвала");
                Console.WriteLine(invFind);
                SpaceData.Inventory.Remove(invFind);
                return Json(invFind);
            }
            else { return Json(null); }
            


        }
    }
}
