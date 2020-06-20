using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Project_TeamMember
    {
        [Key] 
        public int Id { get; set; }

        public int IdProject { get; set; }

        public int IdTeamMember { get; set; }
    }
}
