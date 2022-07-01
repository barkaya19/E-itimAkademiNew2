using DataAccesLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EğitimAkademiNewApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult StudentList()
        {
            using var c = new AppDbContext();
            var students = c.Students.ToList();
            return Ok(students);
        }
        [HttpPost]
        public IActionResult StudentAdd(Student student)
        {
            using var c = new AppDbContext();
            c.Add(student);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult StudentGet(int id)
        {
            using var c = new AppDbContext();
            var student = c.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult StudentDelete(int id)
        {
            using var c = new AppDbContext();
            var student = c.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(student);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult StudentUpdate(Student student)
        {
            using var c = new AppDbContext();
            var std = c.Find<Student>(student.StudentId);
            if (std == null)
            {
                return NotFound();
            }
            else
            {
                std.Name = student.Name;
                c.Update(student);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
