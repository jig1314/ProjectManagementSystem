using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class TimeFrame
    {
        public int Id { get; set; }

        [DisplayName("Time Frame")]
        [Required]
        public string DisplayName { get; set; }
    }
}
