using Microsoft.AspNetCore.Mvc;

namespace KindredHeart.Controllers
{
    public class Appointment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
