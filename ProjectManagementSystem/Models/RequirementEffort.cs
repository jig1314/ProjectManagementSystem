using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementSystem.Models
{
    public class RequirementEffort
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Requirement")]
        [Required]
        public int IdRequirement { get; set; }

        [DisplayName("Team Member")]
        [Required]
        public int IdTeamMember { get; set; }

        [DisplayName("Requirement Effort Type")]
        [Required]
        public int IdRequirementEffortType { get; set; }

        [DisplayName("Time Frame")]
        [Required]
        public int IdTimeFrame { get; set; }

        [DisplayName("Date From")]
        [Required]
        public DateTime DateFrom { get; set; }

        [DisplayName("Date To")]
        public DateTime? DateTo { get; set; }

        [DisplayName("Time Expended")]
        [Column(TypeName = "decimal(16,1)")]
        [Required]
        public decimal TimeExpended { get; set; }
    }
}
