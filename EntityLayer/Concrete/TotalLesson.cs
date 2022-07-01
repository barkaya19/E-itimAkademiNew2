using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TotalLesson
    {
        [Key]
        public int TotalLessonId { get; set; }
        [MaxLength(50)]
        public string LessonName { get; set; }
        [MaxLength(50)]
        public string TeacherName { get; set; }
        [MaxLength(200)]
        public string LessonPoint { get; set; }
    }
}
