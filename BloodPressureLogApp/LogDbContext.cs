using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BloodPressureLogApp
{
   public class LogDbContext:DbContext
    {
        public LogDbContext():base("name=LogDbContext")
        {
            Database.SetInitializer<LogDbContext>(new CreateDatabaseIfNotExists<LogDbContext>());
            //CreateDatabaseIfNotExists
        }
           public DbSet<User> Users {get; set;}
           public DbSet<Entry> Entries {get; set;} 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            /*modelBuilder.Entity<Entry>()
                .HasRequired(u => u.Users)
                .WithMany()
                .HasForeignKey(u => u.UserId);
            base.OnModelCreating(modelBuilder);*/
        }
    }
}
