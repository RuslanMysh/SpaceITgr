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

        [HttpGet("village1")]
        public IActionResult village1()
        {
            return View();
        }

        [HttpGet("surface1")]
        public IActionResult surface1()
        {
            return View();
        }
        [HttpGet("city2")]
        public IActionResult city2()
        {
            return View();
        }

        [HttpGet("village2")]
        public IActionResult village2()
        {
            return View();
        }

        [HttpGet("surface2")]
        public IActionResult surface2()
        {
            return View();
        }

        [HttpGet("city3")]
        public IActionResult city3()
        {
            return View();
        }
        [HttpGet("village3")]
        public IActionResult village3()
        {
            return View();
        }
        [HttpGet("surface3")]
        public IActionResult surface3()
        {
            return View();
        }

        [HttpGet("city4")]
        public IActionResult city4()
        {
            return View();
        }
        [HttpGet("village4")]
        public IActionResult village4()
        {
            return View();
        }
        [HttpGet("surface4")]
        public IActionResult surface4()
        {
            return View();
        }
        [HttpGet("galaxy")]
        public IActionResult galaxy()
        {
            return View();
        }
    }
}
