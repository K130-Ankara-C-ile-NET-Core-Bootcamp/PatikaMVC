using System.Web.Mvc;

namespace PatikaMVC.Controllers
{
    // Controllerlar "Controller" ile biter ama request Controller ifadesi kullanılmaz
    // Viewlar Views/{Controller}/{Action} pathinde tutulur
    // Controller içindeki tüm public methodlar birer Action sayılır
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Merhaba! ViewBag";
            ViewData["Message"] = "Merhaba ViewData";
            TempData["Message"] = "Merhaba Tempdate"; // 2 Request arası hayatta kalır

            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            // Home'dan buraya redirect olduğumuzda bu mesaj gelecek
            // About sayfası direkt açılırsa null gelir
            var message = TempData["Message"];

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}