using Microsoft.AspNetCore.Mvc;
using Register_Login_Task.Data;
using Register_Login_Task.Models;

namespace Register_Login_Task.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User model)
        {

            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                Console.WriteLine("User not found");
            }
            else
            {
                if(user.Email == model.Email && user.Password == model.Password)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(SignIn));
                }
                
            }

            return View(model);
        }
        public IActionResult ChangeStatus(int id)
        {
            var user = _context.Users.Find(id);
            user.Active =!user.Active;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
