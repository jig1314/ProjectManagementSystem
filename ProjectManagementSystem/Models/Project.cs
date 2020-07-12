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
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }

        [DisplayName("Project Manager/Owner Name")]
        [RegularExpression("^([A-Z][a-zA-Z]{1,})(?: [A-Z][a-zA-Z]{0,})?(?: [A-Z][a-zA-Z]{1,})$", ErrorMessage = "Please enter a valid first and last name (Middle name optional)")]
        [Required]
        public string OwnerName { get; set; }
    }
}
