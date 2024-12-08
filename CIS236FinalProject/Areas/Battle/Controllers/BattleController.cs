using Microsoft.AspNetCore.Mvc;

namespace CIS236FinalProject.Areas.Battle.Controllers
{
    public class BattleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
