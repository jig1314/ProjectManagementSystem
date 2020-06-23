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

        public Requirement Requirement { get; set; }

        public RequirementType RequirementType { get; set; }
    }
}
