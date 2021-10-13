using System.Web.Mvc;
using PatikaMVC.Models;

namespace PatikaMVC.Controllers
{
    public class ReturnTypesController : Controller
    {
        // Public her method bir actiondır ve requeste cevap olarak dönüş sağlar.
        // Client tarafından erişilebilir
        // Controllerlar dışarıya çıkış vermeyecek bir metot içermemelidir
        public string PublicMethodAction()
        {
            return "Merhaba!";
        }

        // NonAction attribute'u public methodu Action olmaktan çıkarır
        // Controller içinde business method oluşturmak için kullanılır genel olarak
        [NonAction]
        public string PublicMethodNonAction()
        {
            return "Merhaba!";
        }

        // Boş bir sayfa döner
        public ActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        // Empty result gibi boş sayfa döner
        public void VoidResult()
        {

        }

        public ActionResult JsonResult()
        {
            var user = new UserVM
            {
                Name = "Faruk Aydın"
            };

            return Json(user, JsonRequestBehavior.AllowGet);

            // Aşağıdaki şekilde de json dönebiliriz

            //var userJson = JsonConvert.SerializeObject(user);

            //return new ContentResult
            //{
            //    Content = userJson,
            //    ContentType = "application/json"
            //};
        }
    }
}