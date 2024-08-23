using C__EF_S01_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S01_Assignment.Configuration
{
    internal class ICourseConfiguration : IEntityTypeConfiguration<Course>
    {
     

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Top_Id)
                  .IsRequired();

            builder.Property(c => c.Duration)
                  .HasColumnType("datetime") 
                  .IsRequired();             

            builder.Property(c => c.Name)
                  .IsRequired()              
                  .HasMaxLength(100)         
                  .IsUnicode(true);          

            builder.Property(c => c.Description)
                  .HasMaxLength(500)         
                  .IsUnicode(true);
        }
    }
}
