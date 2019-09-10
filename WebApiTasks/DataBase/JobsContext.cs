using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTasks.DataBase.Model;

namespace WebApiTasks.DataBase
{
    public class JobsContext : DbContext
    {
       
        public JobsContext(DbContextOptions<JobsContext> options) : base(options)
        {

        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagJob>()
                .HasKey(t => new { t.JobId, t.TagId });

            modelBuilder.Entity<TagJob>()
                .HasOne(sc => sc.Tag)
                .WithMany(s => s.TagJobs)
                .HasForeignKey(sc => sc.TagId);

            modelBuilder.Entity<TagJob>()
                .HasOne(sc => sc.Job)
                .WithMany(c => c.TagJobs)
                .HasForeignKey(sc => sc.JobId);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagJob> TagJobs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        //}
    }
}
