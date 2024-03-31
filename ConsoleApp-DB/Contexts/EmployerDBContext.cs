using ConsoleApp_DB.Configurations;
using ConsoleApp_DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DB.Contexts
{
    public class EmployerDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G25JVEL\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.Entity<Employer>()
            .HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employer>? Employers { get; set; }
        public DbSet<Department>? Departments { get; set; }
    }
}
