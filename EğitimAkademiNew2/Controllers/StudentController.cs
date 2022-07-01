using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EğitimAkademiNew2.Controllers
{
    public class StudentController : Controller
    {
        //StudentManager studentManager = new StudentManager(new EfStudentDal());
        AppDbContext appDbContext = new AppDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentGet()
        {
            var students = appDbContext.Students.ToList();
            return View(students);
        }

    }
}
