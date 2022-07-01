using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [MaxLength(100)]
        public string UserLastName { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Area { get; set; }
        [MaxLength(100)]
        public int Age { get; set; }
        [MaxLength(100)]
        public string Scholl { get; set; }
    }
}
