using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectManagementSystem.Models.Project> Project { get; set; }

        public DbSet<ProjectManagementSystem.Models.TeamMember> TeamMember { get; set; }

        public DbSet<ProjectManagementSystem.Models.Project_TeamMember> ProjectTeamMembers { get; set; }

        public DbSet<ProjectManagementSystem.Models.Risk> Risk { get; set; }

        public DbSet<ProjectManagementSystem.Models.ProjectRisk> ProjectRisks { get; set; }

        public DbSet<ProjectManagementSystem.Models.Requirement> Requirement { get; set; }

        public DbSet<ProjectManagementSystem.Models.RequirementType> RequirementTypes { get; set; }
    }
}
