using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class RequirementEffortType
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Requirement Effort Type")]
        [Required]
        public string DisplayName { get; set; }
    }
}
