using Microsoft.AspNetCore.Mvc;

namespace SpaceITgr.Controllers
{
    public class NPCController : Controller
    {
        [Route("NPC1")]
        public IActionResult NPC1()
        {
            return View();
        }

        [Route("NPC2")]
        public IActionResult NPC2()
        {
            return View();
        }

        [Route("NPC3")]
        public IActionResult NPC3()
        {
            return View();
        }
    }
}
