using DataAccesLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EğitimAkademiNewApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        [HttpGet]
        public IActionResult LessonList()
        {
            using var c = new AppDbContext();
            var lessons = c.Lessons.ToList();
            return Ok(lessons);
        }
        [HttpPost]
        public IActionResult LessonAdd(Lesson lesson)
        {
            using var c = new AppDbContext();
            c.Add(lesson);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult LessonGet(int id)
        {
            using var c = new AppDbContext();
            var lesson = c.Lessons.Find(id);
            if (lesson == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(lesson);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult LessonDelete(int id)
        {
            using var c = new AppDbContext();
            var lesson = c.Lessons.Find(id);
            if (lesson == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(lesson);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult LessonUpdate(Lesson lesson)
        {
            using var c = new AppDbContext();
            var lsn = c.Find<Lesson>(lesson.LessonId);
            if (lsn == null)
            {
                return NotFound();
            }
            else
            {
                lsn.LessonName = lesson.LessonName;
                c.Update(lesson);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
