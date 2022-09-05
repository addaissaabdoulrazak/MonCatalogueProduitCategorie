using Microsoft.AspNetCore.Mvc;

namespace MonCatalogueProduitCategorie.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
