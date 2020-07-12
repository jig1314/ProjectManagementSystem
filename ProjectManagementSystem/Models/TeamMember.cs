using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [RegularExpression("^([A-Z][a-zA-Z]{1,})$", ErrorMessage = "Please enter a valid first name only!")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [RegularExpression("^([A-Z][a-zA-Z]{1,})$", ErrorMessage = "Please enter a valid last name only!")]
        [Required]
        public string LastName { get; set; }

    }
}
