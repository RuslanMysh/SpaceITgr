using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
	[Route("System17")]
	public class PlanetController : Controller
	{
		[Route("Planet173")]
		[Route("Earth")]

		[HttpGet]
		public IActionResult Planet173()
		{
			return View();
		}
		[Route("Satellite1731")]
		[Route("Moon")]

		[HttpGet]
		public IActionResult Satellite1731()
		{
			return View();
		}
	}
}
