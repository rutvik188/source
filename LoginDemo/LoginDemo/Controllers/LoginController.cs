using LoginDemo.Data;
using LoginDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginDemo.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
                _db = db;   
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User obj)
        {
          
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index","Login");
            }
            return View(obj);

        }
        public IActionResult ViewUser()
        {
            IEnumerable<User> objUsersList = _db.Users;
            return View(objUsersList);

        }

        public IActionResult Login(string? email,string? password)
        {

            return View();
        }


    }
}
