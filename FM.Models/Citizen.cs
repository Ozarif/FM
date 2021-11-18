using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
    public class Citizen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string FatherName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public string FullName
        {
            get
            { return (FirstName.Trim() + ' ' + FatherName.Trim() + ' ' + LastName.Trim()); }

        }

        [Required]
        [MaxLength(150)]
        public string MotherFullName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(100)]
        public string Province { get; set; }

        [Required]
        [MaxLength(100)]
        public string District { get; set; }

        [Required]
        [MaxLength(100)]
        public string RegisterPlace { get; set; }

        [Required]
        public int RegisterNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Religion { get; set; }

        [Required]
        [MaxLength(100)]
        public string ReligionSect { get; set; }

    }
}
