using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartiesMVC.Models
{
    public class Attendes
    {
        [Required]
        public string  Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        [RegularExpression("^[0-9]*$", ErrorMessage ="ONLY NUMERICS ALLOWED")]
        public string Phone { get; set; }

        [Required]
        public bool? WillAttend { get; set; }

    }
}
