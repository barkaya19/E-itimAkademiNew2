using BusinessLayer.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EğitimAkademiNew2.Controllers
{
    public class LessonController : Controller
    {
        LessonManager lessonManager = new LessonManager(new EfLessonDal());
        TotalLessonManager totalLessonManager = new TotalLessonManager(new EfTotalLessonDal());
        AppDbContext context = new AppDbContext();  
        [Authorize]
        public IActionResult Index()
        {
            var values = lessonManager.TGetList();
            return View(values);
        }
        
        //[HttpPost]
        //public IActionResult YeniDers()
        //{
        //    return View();
        //}
        public IActionResult DersGetir(int id)
        {
            var lesson = lessonManager.TGetByID(id);
            return View("DersGetir");
        }
    }
}
