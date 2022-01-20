using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        ////////////////////////////////////////////////////////////////////

        [Required]
        public int ProvinceID{ get; set; }

        [Required]
        public int DistrictID { get; set; }

        [Required]
        public int RegisterPlaceID { get; set; }

        ////////////////////////////////////////////////////////////////////

        [Required]
        public int RegisterNumber { get; set; }

        public int PersonalReligionSectionID { get; set; }


        public int RegisterReligionSectionID { get; set; }


        [Required]
        public int GenderID { get; set; }

       public Gender Gender { get; set; }

    }
}
