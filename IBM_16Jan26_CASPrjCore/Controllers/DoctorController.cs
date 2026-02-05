using Microsoft.AspNetCore.Mvc;

namespace IBM_16Jan26_CASPrjCore.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
