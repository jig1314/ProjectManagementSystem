using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.ViewModels
{
    public class RequirementEffortViewModel
    {
        public int Id { get; set; }

        public RequirementEffort RequirementEffort { get; set; }

        public Requirement Requirement { get; set; }

        [DisplayName("Effort Type")]
        public RequirementEffortType RequirementEffortType { get; set; }

        [DisplayName("Team Member")]
        public TeamMemberViewModel TeamMember { get; set; }

        [DisplayName("Time Frame")]
        public TimeFrame TimeFrame { get; set; }

        [DisplayName("Start Date")]
        public DateTime DateFrom { get; set; }

        [DisplayName("End Date")]
        public DateTime? DateTo { get; set; }

        [DisplayName("Time Expended (in hrs)")]
        public decimal TimeExpended { get; set; }

    }
}
