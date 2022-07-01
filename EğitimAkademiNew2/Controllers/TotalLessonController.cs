using BusinessLayer.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EğitimAkademiNew2.Controllers
{
    public class TotalLessonController : Controller
    {
        TotalLessonManager totalLessonManager= new TotalLessonManager(new EfTotalLessonDal());
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetTotal()
        {
            var total = totalLessonManager.TGetList();
            return View(total);
        }
        //[HttpPost]
        //public IActionResult YeniDers(Lesson l)
        //{
        //  context.Lessons.Add(l);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpGet]
        public IActionResult YeniDers1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDers1(TotalLesson l)
        {
            context.TotalLessons.Add(l);
            context.SaveChanges();
            return RedirectToAction("Index","Lesson");
        }
    }
}
