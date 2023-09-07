using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectEnd1.Models;

namespace ProjectEnd1.Data
{
    public class ProjectEndDbContext : DbContext
    {
        public ProjectEndDbContext (DbContextOptions<ProjectEndDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectEnd1.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<ProjectEnd1.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
