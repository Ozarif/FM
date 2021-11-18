using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "City Name")]
        public string Name { get; set; }

        [Required]
        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }
    }
}
