using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationTask3.Data;
using WebApplicationTask3.Models;

namespace WebApplicationTask3.Controllers
{
    public class AccountController : Controller
    {

        private AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Roles = new SelectList(_context.Roles, "Id", "RoleName");
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, int Password)
        {
            var user = _context.Users.Where(x => x.Email == Email && x.Password == Password);
            if(user.Any())
            {
                return RedirectToAction("Login");
            }
            ModelState.AddModelError("", "Invalid login attemp");
            return View();
        }
    }
}
