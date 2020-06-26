using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.ViewModels
{
    public class RequirementViewModel
    {
        public int Id { get; set; }

        [DisplayName("Requirement")]
        [Required]
        public string RequirementName { get; set; }

        [Required]
        public string Description { get; set; }

        [UIHint("RequirementTypeDropDown")]
        public RequirementType RequirementType { get; set; }
    }
}
