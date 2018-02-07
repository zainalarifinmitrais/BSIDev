using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BSI.Domain.Dto
{    
    public class UserDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string UserName { get; set; }

        [Required]
        [MinLength(8)]
        public string UserPassword { get; set; }

        [Required]
        public List<string> Role { get; set; }

    }
}
