using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public int Id { get; set; }

        [DisplayName("Project Name")]
        public string Name { get; set; }

        [DisplayName("High-Level Description")]
        public string Description { get; set; }

        [DisplayName("Project Manager/Owner Name")]
        public string OwnerName { get; set; }

        public List<TeamMember> TeamMembers { get; set; }

        public List<Risk> Risks { get; set; }
    }
}
