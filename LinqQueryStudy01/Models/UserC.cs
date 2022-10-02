using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueryStudy01.Models
{
    public class UserC
    {
        [Key]
        public int UserNo { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string UserPW { get; set; }
        [Required]
        public string UserPhone { get; set; }
    }
}
