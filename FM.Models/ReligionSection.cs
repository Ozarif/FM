using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
    public class ReligionSection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Religion Section Name")]
        public string Name { get; set; }
    }
}
