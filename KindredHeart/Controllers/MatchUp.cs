using Microsoft.AspNetCore.Mvc;

namespace KindredHeart.Controllers
{
    public class MatchUp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
