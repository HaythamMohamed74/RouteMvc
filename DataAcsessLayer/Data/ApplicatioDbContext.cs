using DataAcsessLayer.Data.Configurations;
using DataAcsessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Data
{
    public class ApplicatioDbContext:DbContext
    {
       

        public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext>options):base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-662AKIO\\SQLEXPRESS;Initial Catalog=MVCApplication;Integrated Security=True;Trust Server Certificate=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> Departments { get; set; }

    }

}
