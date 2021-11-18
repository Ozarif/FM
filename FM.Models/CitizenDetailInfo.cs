using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
   public class CitizenDetailInfo
    {

        [Key]
        [ForeignKey("Citizen")]
        public int CitizenId { get; set; }
        public virtual Citizen Citizen { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sex { get; set; }
        //[Required]
        //public int ProvinceId { get; set; }

        //[ForeignKey("ProvinceId")]
        //public Province Province { get; set; }

        //[Required]
        //public int DistrictId { get; set; }

        //[ForeignKey("DistrictId")]
        //public District District { get; set; }

        [Required]
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(100)]
        public string Building { get; set; }

        public int Floor { get; set; }

        [Required]
        public int HomeTypeId { get; set; }

        [ForeignKey("HomeTypeId")]
        public HomeType HomeType { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public int MaritalStatusId { get; set; }

        [ForeignKey("MaritalStatusId")]
        public MaritalStatus MaritalStatus { get; set; }

        public bool IsDisabled { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nationality { get; set; }

        [Required]
        public int EducationalLevelId { get; set; }

        [ForeignKey("EducationalLevelId")]
        public EducationalLevel EducationalLevel { get; set; }

        //[Required]
        public int BusinessSectorId { get; set; }

        [ForeignKey("BusinessSectorId")]
        public BusinessSector BusinessSector { get; set; }

        [Required]
        public int PartyDivisionId { get; set; }

        [ForeignKey("PartyDivisionId")]
        public PartyDivision PartyDivision { get; set; }

        //[Required]
        public int PartyPositionId { get; set; }

        [ForeignKey("PartyPositionId")]
        public PartyPosition PartyPosition { get; set; }

        //[Required]
        public int ElectionRoleId { get; set; }

        [ForeignKey("ElectionRoleId")]
        public ElectionRole ElectionRole { get; set; }
    }
}
