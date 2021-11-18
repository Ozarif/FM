using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FM.Models
{
    public class FamilyMemberInfo
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required]
        public int CitizenId
        {
            get; set;
        }

        [Required]
        [Display(Name = "Member Name")]
        [MaxLength(100)]
        public string Name
        {
            get; set;
        }

        public enum SexType { Female, Male }

        [Required]
        public SexType Sex { get; set; }

        [Required]
        public int MemberRelationTypeId
        {
            get; set;
        }

        [ForeignKey("MemberRelationTypeId")]
        public MemberRelationType MemberRelationType { get; set; }

        [Required]
        public DateTime DateOfBirth
        {
            get; set;
        }
    }
}
