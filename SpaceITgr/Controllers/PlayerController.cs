using Microsoft.AspNetCore.Mvc;
using SpaceITgr.Models;
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
	}
}
