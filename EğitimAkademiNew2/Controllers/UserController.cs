using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EğitimAkademiNew2.Controllers
{
    public class UserController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            var user = context.Users.ToList();
            return View(user);
        }
    }
}
