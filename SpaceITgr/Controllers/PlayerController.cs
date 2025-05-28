using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
	public class PlayerController : Controller
	{
		public IActionResult Player()
		{
			return View();
		}
	}
}
