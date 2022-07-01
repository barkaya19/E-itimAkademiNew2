using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        [MaxLength(50)]
        public string LessonName { get; set; }
        [MaxLength(50)]
        public string TeacherName { get; set; }
        [MaxLength(200)]
        public string LessonPoint { get; set; }
        [MaxLength(300)]
        public string LessonAbout { get; set; }
        [MaxLength(50)]
        public string LessonContents { get; set; }
        [MaxLength(500)]
        public string LessonComment { get; set; }
    }
}
