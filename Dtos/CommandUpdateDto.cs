using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
        [Required]
        [MaxLength(100)]
        public string Platform { get; set; }
    }
}
