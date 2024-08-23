using C__EF_S01_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S01_Assignment.Contexts
{
    public class ITIDbContext:DbContext
    {

        #region By Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>(CI =>
            {

                CI.HasKey(ci =>new {ci.Course_Id,ci.Inst_Id  });//Primary Key Is Called Id

               CI.Property(nameof(Course_Instructor.Evaluate))
                .HasColumnName("Evaluation")
                .HasColumnType("varchar(200)")
                .IsRequired();



            });
        }

        #endregion
        #region Convention And Annotation
        public ITIDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITINewVersion;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Student> Students { get; set; }//Become Table IN Database Named==>Students
        public DbSet<Instructor> Instructors { get; set; }//Become Table IN Database Named==>Instructors
        public DbSet<Topic> Topics { get; set; }//Become Table IN Database Named==>Topics
        public DbSet<Department> Departments { get; set; }//Become Table IN Database Named==>Topics


        #endregion
    }
}
