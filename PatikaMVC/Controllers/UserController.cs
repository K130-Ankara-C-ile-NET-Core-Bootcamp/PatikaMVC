using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PatikaMVC.Models;

namespace PatikaMVC.Controllers
{
    // Default olarak her action GET ile çalışır
    public class UserController : Controller
    {
        private static List<UserVM> _users = new List<UserVM>() {
            new UserVM
            {
                Name = "Faruk Aydın"
            }
        };

        [HttpGet]
        public ActionResult List()
        {
            return View(_users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name)
        {
            _users.Add(new UserVM
            {
                Name = name
            });

            return View();
        }

        [HttpPost]
        public ActionResult Delete(string userName)
        {
            var userToRemove = _users.FirstOrDefault(x => x.Name == userName);
            _users.Remove(userToRemove);

            return RedirectToAction("List");
        }
    }
}