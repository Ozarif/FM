using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Models
{
   public  class ServiceInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CitizenId { get; set; }
        [Required]
        public int ServiceTypeId { get; set; }

        [ForeignKey("ServiceTypeId")]
        public ServiceType ServiceType { get; set; }

        [Required]
        [MaxLength(150)]
        public string ContactName { get; set; }

        //[Required]
        [MaxLength(50)]
        public string ContactNumber { get; set; }

        [Required]
        public int ResultTypeId { get; set; }

        [ForeignKey("ResultTypeId")]
        public ResultType ResultType { get; set; }

    }
}
