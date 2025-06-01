using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
    [Route("Locality")]
    public class CityController : Controller
    {
        [HttpGet("city1")]
        public IActionResult city1()
        {
            return View();
        }

        [HttpGet("v1")]
        public IActionResult v1()
        {
            return View();
        }

        [HttpGet("s1")]
        public IActionResult s1()
        {
            return View();
        }
    }
}
