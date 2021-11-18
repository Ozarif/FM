using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
    public class ReferenceInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CitizenId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string ContactNumber { get; set; }

        //[Required]
        public int PartyPositionId { get; set; }

        [ForeignKey("PartyPositionId")]
        public PartyPosition PartyPosition { get; set; }
    }
}
