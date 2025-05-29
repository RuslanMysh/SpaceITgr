using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
    public class CityController : Controller
    {
        [Route("CapitalCity")]
        public IActionResult CapitalCity()
        {
            return View();
        }

        [Route("Village")]
        public IActionResult Village()
        {
            return View();
        }

        [Route("Surface")]
        public IActionResult Surface()
        {
            return View();
        }
    }
}
