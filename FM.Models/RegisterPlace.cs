using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
    public class RegisterPlace
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Register Place Name")]
        public string Name { get; set; }

        [Required]
        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }
    }
}
