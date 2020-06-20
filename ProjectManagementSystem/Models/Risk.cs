using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Risk
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Risk")]
        [Required]
        public string RiskName { get; set; }

        [DisplayName("Risk Status")]
        [Required]
        public string RiskStatus { get; set; }  
    }
}
