using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Project_Risk
    {
        public int Id { get; set; }  

        public int IdProject { get; set; }

        public int IdRisk { get; set; }
    }
}
