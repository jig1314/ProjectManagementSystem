using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.ViewModels
{
    public class TeamMemberViewModel
    {
        public int Id { get; set; }

        [RegularExpression("^([A-Z][a-zA-Z]{1,})$", ErrorMessage = "Please enter a valid first name only!")]
        [Required]
        public string FirstName { get; set; }

        [RegularExpression("^([A-Z][a-zA-Z]{1,})$", ErrorMessage = "Please enter a valid last name only!")]
        [Required]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

    }
}
