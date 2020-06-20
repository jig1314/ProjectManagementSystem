using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Project Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("High-Level Description")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Project Manager/Owner Name")]
        [Required]
        public string OwnerName { get; set; }
    }
}
