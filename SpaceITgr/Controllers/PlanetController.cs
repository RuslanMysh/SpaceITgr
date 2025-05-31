using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
    [Route("")]
    [Route("System17")]
	public class PlanetController : Controller
	{
		[Route("Planet173")]
		[Route("Земля")]

		[Route("")]
		[HttpGet]
		public IActionResult Index()//Planet173
        {
			return View();
		}
		[Route("Satellite1731")]
		[Route("Луна")]

		[HttpGet]
		public IActionResult Satellite1731()
		{
			return View();
		}
	}
}
