using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSI.Domain.Models
{
    [Table("Role")]
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
