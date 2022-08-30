using InterviewTracker.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTracker.DataLayer
{
    public class InterviewTrackerDbContext : DbContext
    {
        public InterviewTrackerDbContext(DbContextOptions<InterviewTrackerDbContext> dbContextOptions)
            : base(dbContextOptions)
        { 
            //Database.Migrate();
        }

        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
       
    }
}
