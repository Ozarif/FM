using System;
using System.ComponentModel.DataAnnotations;

namespace FM.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Province Name")]
        public string Name { get; set; }
    }
}
