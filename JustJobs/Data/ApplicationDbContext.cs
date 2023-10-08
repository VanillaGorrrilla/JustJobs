using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JustJobs.Models;

namespace JustJobs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JustJobs.Models.JobApplication> JobApplication { get; set; }
        public DbSet<JustJobs.Models.Interview> Interview { get; set; }
    }
}
