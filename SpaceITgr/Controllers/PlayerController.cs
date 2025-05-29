using Microsoft.AspNetCore.Mvc;
using SpaceITgr.Models;

namespace SpaceITgr.Controllers
{
	[Route("Player")]
	public class PlayerController : Controller
	{
        [Route("PlayerPlanets")]
        public JsonResult PlayerPlanets()
		{
			return Json(SpaceData.Planets);
		}
	}
}
