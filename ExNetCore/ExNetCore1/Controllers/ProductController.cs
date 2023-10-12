using Microsoft.AspNetCore.Mvc;

namespace ExNetCore1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
