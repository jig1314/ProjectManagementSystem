using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Requirement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdProject { get; set; }

        [DisplayName("Requirement")]
        [Required]
        public string RequirementName { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Requirement Type")]
        [Required]
        public int IdRequirementType { get; set; }
    }
}
